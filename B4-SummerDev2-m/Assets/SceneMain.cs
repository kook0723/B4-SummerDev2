using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class SceneMain : MonoBehaviour
    {

        private GameController mGame;
        [SerializeField]
        private BlockManager mBlock;

        void Awake()
        {
            mGame = GameController.Instance;
            mGame.Init();
        }

        //-------------
        // 状態と更新 //
        //---------------------------------------------------------------------------------

        private enum STATE
        {
            DEFAULT = 0
        }
        private STATE mState = STATE.DEFAULT;

        void Update()
        {
            mBlock.CheckMouseInput();
            switch (mState)
            {

            }
        }
    }