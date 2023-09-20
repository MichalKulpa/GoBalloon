using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GB.Data
{
    public class GameDataStorage : MonoBehaviour
    {
        [SerializeField]
        private SpeedData speedData;


        public SpeedData SpeedData => speedData;
    }
}

