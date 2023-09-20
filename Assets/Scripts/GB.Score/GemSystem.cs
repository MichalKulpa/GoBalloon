using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GB.UI;
namespace GB.Score
{
    public class GemSystem
    {
        private GameView gameView;


        private int currentGems;

        public int CurrentGems => currentGems;
        public void InitializeGems(GameView gameView)
        {
            this.gameView = gameView;
        }
        public void AddGem()
        {
            AddGems(1);
        }
        public void AddGems(int count)
        {
            currentGems+=count;
            gameView.UpdateGems(currentGems);
        }
    }
}

