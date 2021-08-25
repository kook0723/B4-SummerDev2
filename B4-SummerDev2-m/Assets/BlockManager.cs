using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

    public class BlockManager : MonoBehaviour
    {

        [SerializeField]
        private GameObject mPrefabBlock;

        // ブロックの辺のサイズ
        private readonly float BLOCK_SIZE = 1.0f;
        private readonly float BLOCK_SIZE_HALF = 0.5f;

        // ブロックをListで管理
        private List<BlockModel> mBlockList = new List<BlockModel>();

        void Start () {
            CreateField(GameController.LEVEL_EASY);
        }

        private readonly float CAMERA_OFFSET_Z = 6.5f;

        /// <summary>
        /// フィールドを生成する
        /// </summary>
        public void CreateField(int gameLevel)
        {
            // 前のブロックが存在する場合は全て破棄
            foreach(BlockModel model in mBlockList)
            {
                Destroy(model.gameObject);
            }
            mBlockList.Clear();

            // ゲームレベルによってサイズと爆弾の数を決定
            int xLength;
            int yLength;
            int bombCount;
            switch (gameLevel)
            {
                case GameController.LEVEL_EASY:
                    xLength = 9;
                    yLength = 9;
                    bombCount = 10;
                    break;
                case GameController.LEVEL_NORMAL:
                    xLength = 16;
                    yLength = 16;
                    bombCount = 40;
                    break;
                default:
                    xLength = 30;
                    yLength = 16;
                    bombCount = 99;
                    break;
            }

            // ブロックを並べる
            InstantiateBlocks(xLength, yLength);

            // ブロックに爆弾を設置
            SetBombs(bombCount);

            // カメラを中心に設定
            float cameraX = xLength * BLOCK_SIZE / 2.0f;
            float cameraZ = yLength * BLOCK_SIZE / 2.0f - CAMERA_OFFSET_Z;
            float cameraY = 6.5f;
            Transform cameraTrans = Camera.main.transform;
            cameraTrans.position = new Vector3(cameraX, cameraY, cameraZ);
            cameraTrans.rotation = Quaternion.Euler(new Vector3(50.0f, 0.0f, 0.0f));
        }

        /// <summary>
        /// ブロックに爆弾を設置する
        /// </summary>
        /// <param name="bombCount">配置する爆弾の数</param>
        private void SetBombs(int bombCount)
        {
            // Listをシャッフルして先頭から爆弾を設置していく
            int blockCount = mBlockList.Count;
            for (int i = 0; i < blockCount; i++)
            {
                BlockModel temp = mBlockList[i];
                int rand = UnityEngine.Random.Range(0, blockCount);
                mBlockList[i] = mBlockList[rand];
                mBlockList[rand] = temp;
            }
            for(int i=0; i<bombCount; i++)
            {
                mBlockList[i].HasBomb = true;
            }
        }


        /// <summary>
        /// ブロックを並べる
        /// 同時に生成されたBlockModelをListに格納する
        /// </summary>
        /// <param name="xLength"></param>
        /// <param name="yLength"></param>
        private void InstantiateBlocks(int xLength, int yLength)
        {
            for(int y=0; y<yLength; y++)
            {
                for(int x=0; x<xLength; x++)
                {
                    GameObject blockGo = Instantiate(mPrefabBlock, new Vector3(x * BLOCK_SIZE + BLOCK_SIZE_HALF, BLOCK_SIZE_HALF, y * BLOCK_SIZE + BLOCK_SIZE_HALF), Quaternion.identity, transform);
                    BlockModel blockModel = blockGo.GetComponent<BlockModel>();
                    blockModel.SetPosition(x, y);
                    mBlockList.Add(blockModel);
                }
            }
        }

    }