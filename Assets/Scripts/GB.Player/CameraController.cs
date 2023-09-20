using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GB.Data;
namespace GB.Player
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        private Camera playerCamera;
        [SerializeField]
        private PlayerMovement player;

        private SpeedData speedData;
        public void InitializeSystem(GameDataStorage storage)
        {
            speedData = storage.SpeedData;
        }
        public void UpdateCameraPosition()
        {
            if (player.PlayerPos.y > 2)
            {
                playerCamera.transform.position += Vector3.up * (Time.deltaTime * speedData.PlayerBaseSpeed);
            }
            
        }
    }
}

