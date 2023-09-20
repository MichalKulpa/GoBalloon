using System;
using System.Collections.Generic;
using UnityEngine;
using GB.Data;
using GB.Score;
using GB.Level;

namespace GB.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        //[SerializeField]
        //private new Rigidbody rigidbody;


        private SpeedData speedData;
        private Vector3 windDirectrion= new Vector3(1,0,0);
        private Action onLose;
        private LevelSpawner spawner;
        private GemSystem gemSystem;

        public Vector3 PlayerPos => transform.position;

        public void InitializeSystem(GameDataStorage storage,GemSystem gemSystem,LevelSpawner spawner)
        {
            this.speedData = storage.SpeedData;
            this.gemSystem = gemSystem;
            this.spawner = spawner;
        }

        public void AddOnLoseListener(Action callback)
        {
            this.onLose = callback;
        }

        public void UpdatePlayerPosition()
        {
            transform.position += Vector3.up * (Time.deltaTime * speedData.PlayerBaseSpeed);                        
            transform.position += windDirectrion * (Time.deltaTime *  speedData.WindStrenght);
            if (transform.position.x > 3.3||transform.position.x<-3.3)
            {
                transform.position = new Vector3(transform.position.x*-1, transform.position.y, transform.position.z);
            }
            
        }
        public void ChangeWindDirection()
        {
            windDirectrion *= -1;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Cleaner"))
            {
                
                spawner.DestroySpawn();
                
            }
            if (other.CompareTag("Obstacle"))
            {
                onLose?.Invoke();
            }
            if (other.CompareTag("Gem"))
            {
                gemSystem.AddGem();
                Destroy(other.gameObject);
            }
        }
    }
}

