using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GB.Score
{
    public class TimeSystem
    {
        private int secondsPassed;
        private float startTime;

        public int SecondsPassed => secondsPassed;

        public void StartCounting()
        {
            secondsPassed = 0;
            startTime = Time.time;
        }

        public void UpdateTime()
        {
            secondsPassed = (int)(Time.time - startTime);
        }
    }
}

