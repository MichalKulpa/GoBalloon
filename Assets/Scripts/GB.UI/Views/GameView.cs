using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace GB.UI
{
    public class GameView : BaseView
    {
        [SerializeField]
        private TextMeshProUGUI heightText;
        [SerializeField]
        private TextMeshProUGUI gemsText;
        [SerializeField]
        private TextMeshProUGUI timeText;
       

        public void UpdateHeight(int height)
        {
            heightText.text = $"{height.ToString()} m";
        }

        public void UpdateTime(int secondsPassed)
        {
            var minutes = secondsPassed / 60;
            var seconds = secondsPassed % 60;

            var date = new DateTime(1,1,1,1,minutes,seconds);

            timeText.text = $"{date:mm:ss}";
        }
        public void UpdateGems(int gems)
        {
            gemsText.text = $"{gems.ToString()}";
        }
    }
}

