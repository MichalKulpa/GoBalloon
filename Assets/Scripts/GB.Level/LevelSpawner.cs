using GB.Player;
using UnityEngine;
using System.Collections.Generic;
namespace GB.Level
{
    public class LevelSpawner : MonoBehaviour
    {
        [SerializeField]
        private PlayerMovement playerAltitude;
        [SerializeField]
        private Transform player;
        [SerializeField]
        private Transform obstaclePrefab;
        [SerializeField]
        private Transform gemPrefab;

        private int tempObstacleAltitude = 0;
        private int tempGemAltitude = 0;

        [SerializeField]
        private Queue<Transform> spawns= new Queue<Transform>();

        public void UpdateLevel()
        {
            SpawnObstacle(obstaclePrefab, GenerateSpawnPosition(5), 3);           
            SpawnGem(gemPrefab, GenerateSpawnPosition(15), 10);
        }

        public void SpawnGem(Transform prefab, Vector3 spawnPosition, int density)
        {

            if (UpdateAltitude() != tempGemAltitude && UpdateAltitude() % density == 0)
            {

                var gem = Instantiate(prefab, spawnPosition, prefab.rotation);
                spawns.Enqueue(gem);
                tempGemAltitude = UpdateAltitude();

            }
        }
        public void SpawnObstacle(Transform prefab, Vector3 spawnPosition, int density)
        {

            if (UpdateAltitude() != tempObstacleAltitude && UpdateAltitude() % density == 0)
            {

                var obstacle = Instantiate(prefab, spawnPosition, prefab.rotation);
                spawns.Enqueue(obstacle);
                tempObstacleAltitude = UpdateAltitude();

            }
        }

        public void DestroySpawn()
        {
            var spawnToDestroy = spawns.Dequeue();
            Destroy(spawnToDestroy.gameObject);
        }

        private Vector3 GenerateSpawnPosition(int spawnRange)
        {
            return new Vector3(Random.Range(-2.3f, 2.3f), player.position.y + Random.Range(10, 10 + spawnRange), player.position.z);
        }
        private int UpdateAltitude()
        {
            int altitude = (int)player.position.y;
            return altitude;
        }

        

        private bool SpawnCondition()
        {
            int spawnCondition = Random.Range(0, 10);
            if (spawnCondition > 5)
                return true;
            else
                return false;
        }
    }
}

