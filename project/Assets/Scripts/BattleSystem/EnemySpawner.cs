using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public class EnemySpawner : MonoBehaviour
    {
        public SpawnableEnemies SpawnableEnemies;
        public GameObject AttachTo;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public List<Enemy> SpawnEnemiesFrom(CollisionData collisionData)
        {
            var enemiesSpawned = new List<Enemy>();
            Vector3 location = collisionData.CollidedFrom.transform.position;
            var wolf1 = Instantiate(SpawnableEnemies.enemies[0], new Vector3(location.x - 2, location.y), Quaternion.identity, AttachTo.transform);
            enemiesSpawned.Add(wolf1);

            var wolf2 = Instantiate(SpawnableEnemies.enemies[0], new Vector3(location.x - 3, location.y + 1), Quaternion.identity, AttachTo.transform);
            enemiesSpawned.Add(wolf2);

            Destroy(collisionData.CollidedWith);

            return new List<Enemy>
        {
            wolf1,
            wolf2
        };
        }
    }
}

