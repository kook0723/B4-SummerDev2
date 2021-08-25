using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class NumberChanger : MonoBehaviour
    {

        // 初期化 

        private void Awake()
        {
            // 最初は何も表示しないテクスチャを設定
            ChangeUvToBlank();
        }

        // UVマップの切り替え //

       //1
        private static Vector2[] UV_ONE = 
        {
            //右前向き
            new Vector2(0.25f, 1.0f),
            new Vector2(0.0f, 1.0f),
            new Vector2(0.25f, 0.75f),
            new Vector2(0.0f, 0.75f)

            //左前向き
            //new Vector2(0.0f, 1.0f),
            //new Vector2(0.0f, 0.75f),
            //new Vector2(0.25f, 1.0f),
            //new Vector2(0.25f, 0.75f)
        };

        //2
        private static Vector2[] UV_TWO =
        {
            //右前向き
            new Vector2(0.5f, 1.0f),
            new Vector2(0.25f, 1.0f),
            new Vector2(0.5f, 0.75f),
            new Vector2(0.25f, 0.75f)

            //左前向き
            //new Vector2(0.25f, 1.0f),
            //new Vector2(0.25f, 0.75f),
            //new Vector2(0.5f, 1.0f),
            //new Vector2(0.5f, 0.75f)

        };

        //3
        private static Vector2[] UV_THREE =
        {
            //右前向き
            new Vector2(0.75f, 1.0f),
            new Vector2(0.5f, 1.0f),
            new Vector2(0.75f, 0.75f),
            new Vector2(0.5f, 0.75f)

            //左前向き
            //new Vector2(0.5f, 1.0f),
            //new Vector2(0.5f, 0.75f),
            //new Vector2(0.75f, 1.0f),
            //new Vector2(0.75f, 0.75f)

        };

        //4
        private static Vector2[] UV_FOUR =
        {
            //右前向き
            new Vector2(1.0f, 1.0f),
            new Vector2(0.75f, 1.0f),
            new Vector2(1.0f, 0.75f),
            new Vector2(0.75f, 0.75f)

            //左前向き
            //new Vector2(0.75f, 1.0f),
            //new Vector2(0.75f, 0.75f),
            //new Vector2(1.0f, 1.0f),
            //new Vector2(1.0f, 0.75f)
        };

        //5
        private static Vector2[] UV_FIVE =
        {
            //右前向き
            new Vector2(0.25f, 0.75f),
            new Vector2(0.0f, 0.75f),
            new Vector2(0.25f, 0.5f),
            new Vector2(0.0f, 0.5f)

            //左前向き
            //new Vector2(0.0f, 0.75f),
            //new Vector2(0.0f, 0.5f),
            //new Vector2(0.25f, 0.75f),
            //new Vector2(0.25f, 0.5f)
        };

        //6
        private static Vector2[] UV_SIX =
        {
            //右前向き
            new Vector2(0.5f, 0.75f),
            new Vector2(0.25f, 0.75f),
            new Vector2(0.5f, 0.5f),
            new Vector2(0.25f, 0.5f)

            //左前向き
            //new Vector2(0.25f, 0.75f),
            //new Vector2(0.25f, 0.5f),
            //new Vector2(0.5f, 0.75f),
            //new Vector2(0.5f, 0.5f)
        };

        //7
        private static Vector2[] UV_SEVEN =
        {
            //右前向き
            new Vector2(0.75f, 0.75f),
            new Vector2(0.5f, 0.75f),
            new Vector2(0.75f, 0.5f),
            new Vector2(0.5f, 0.5f)

            //左前向き
            //new Vector2(0.5f, 0.75f),
            //new Vector2(0.5f, 0.5f),
            //new Vector2(0.75f, 0.75f),
            //new Vector2(0.75f, 0.5f)

        };

        //8
        private static Vector2[] UV_EIGHT =
        {
            //右前向き
            new Vector2(1.0f, 0.75f),
            new Vector2(0.75f, 0.75f),
            new Vector2(1.0f, 0.5f),
            new Vector2(0.75f, 0.5f)

            //左前向き
            //new Vector2(0.75f, 0.75f),
            //new Vector2(0.75f, 0.5f),
            //new Vector2(1.0f, 0.75f),
            //new Vector2(1.0f, 0.5f)
        };

        //黒ドクロ
        private static Vector2[] UV_BOMB_A =
        {
            //右前向き
            new Vector2(0.25f, 0.5f),
            new Vector2(0.0f, 0.5f),
            new Vector2(0.25f, 0.25f),
            new Vector2(0.0f, 0.25f)

            //左前向き
            //new Vector2(0.0f, 0.5f),
            //new Vector2(0.0f, 0.25f),
            //new Vector2(0.25f, 0.5f),
            //new Vector2(0.25f, 0.25f)
        };

        //赤ドクロ
        private static Vector2[] UV_BOMB_B =
        {
            //右前向き
            new Vector2(0.5f, 0.5f),
            new Vector2(0.25f, 0.5f),
            new Vector2(0.5f, 0.25f),
            new Vector2(0.25f, 0.25f)

            //左前向き
            //new Vector2(0.25f, 0.5f),
            //new Vector2(0.25f, 0.25f),
            //new Vector2(0.5f, 0.5f),
            //new Vector2(0.5f, 0.25f)
        };

        //チェックマーク
        private static Vector2[] UV_CHECK =
        {
            //右前向き
            new Vector2(0.75f, 0.5f),
            new Vector2(0.5f, 0.5f),
            new Vector2(0.75f, 0.25f),
            new Vector2(0.5f, 0.25f)

            //左前向き
            //new Vector2(0.5f, 0.5f),
            //new Vector2(0.5f, 0.25f),
            //new Vector2(0.75f, 0.5f),
            //new Vector2(0.75f, 0.25f)
        };

        //空白（空いていない状態）
        private static Vector2[] UV_BLANK =
        {
            //右前向き&左前向き
            new Vector2(1.0f, 0.5f),
            new Vector2(0.75f, 0.5f),
            new Vector2(1.0f, 0.25f),
            new Vector2(0.75f, 0.25f)
        };

        /// <summary>
        /// UVマップを爆弾に変更
        /// </summary>
        public void ChangeUvToBombA()
        {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            mesh.uv = UV_BOMB_A;
        }

        /// <summary>
        /// UVマップを特別な爆弾に変更
        /// </summary>
        public void ChangeUvToBombB()
        {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            mesh.uv = UV_BOMB_B;
        }

        /// <summary>
        /// UVマップをチェックに変更
        /// </summary>
        public void ChangeUvToCheck()
        {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            mesh.uv = UV_CHECK;
        }

        /// <summary>
        // UVマップをブランクに変更
        /// </summary>
        public void ChangeUvToBlank()
        {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            mesh.uv = UV_BLANK;
        }

        /// <summary>
        // 自分の周りにある爆弾の数によってUVマップを変更する
        /// </summary>
        /// <param name="aroundBombs">隣接1マス内にある爆弾の数</param>
        public void ChangeNumber(int aroundBombs)
        {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            switch (aroundBombs)
            {
                case 1:
                    mesh.uv = UV_ONE;
                    break;
                case 2:
                    mesh.uv = UV_TWO;
                    break;
                case 3:
                    mesh.uv = UV_THREE;
                    break;
                case 4:
                    mesh.uv = UV_FOUR;
                    break;
                case 5:
                    mesh.uv = UV_FIVE;
                    break;
                case 6:
                    mesh.uv = UV_SIX;
                    break;
                case 7:
                    mesh.uv = UV_SEVEN;
                    break;
                case 8:
                    mesh.uv = UV_EIGHT;
                    break;
                default:
                    mesh.uv = UV_BLANK;
                    break;
            }
        }

    }

