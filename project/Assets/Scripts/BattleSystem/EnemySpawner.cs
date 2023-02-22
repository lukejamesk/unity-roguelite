using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public SpawnableEnemies SpawnableEnemies;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemiesFrom(CollisionData collisionData)
    {

        Debug.Log("Spawning enemies");
        Debug.Log(collisionData.CollidedWith);

        var enemiesSpawned = new List<Enemy>();
        Vector3 location = collisionData.CollidedWith.transform.position;
        var wolf1 = Instantiate(SpawnableEnemies.enemies[0], location, Quaternion.identity);
        enemiesSpawned.Add(wolf1);

        var wolf2 = Instantiate(SpawnableEnemies.enemies[0], new Vector3(location.x - 1, location.y + 1), Quaternion.identity);
        enemiesSpawned.Add(wolf2);

        Destroy(collisionData.CollidedWith);
    }
}
