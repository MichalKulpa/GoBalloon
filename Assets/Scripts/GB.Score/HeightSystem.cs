using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GB.Score
{
    public class HeightSystem
    {
        private int height;
        public int Height => height;

        public void UpdateHeight(Vector3 PlayerPos)
        {
            height = (int)PlayerPos.y;
        }
    }
}

