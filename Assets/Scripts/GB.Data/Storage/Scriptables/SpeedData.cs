using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GB.Data
{
    [CreateAssetMenu(menuName = "Storage/SpeedData")]
    public class SpeedData : ScriptableObject
    {
        [SerializeField]
        private float playerBaseSpeed;
        [SerializeField]
        private float windStrenght;


        public float PlayerBaseSpeed => playerBaseSpeed;
        public float WindStrenght => windStrenght;
    }
}

