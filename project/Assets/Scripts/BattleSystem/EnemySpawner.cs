using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public List<Entity> SpawnEnemiesFrom(CollisionData collisionData)
    {
        var enemiesSpawned = new List<Entity>();
        Vector3 location = collisionData.CollidedWith.transform.position;
        var wolf1 = Instantiate(SpawnableEnemies.enemies[0], location, Quaternion.identity, AttachTo.transform);
        enemiesSpawned.Add(wolf1);

        var wolf2 = Instantiate(SpawnableEnemies.enemies[0], new Vector3(location.x - 1, location.y + 1), Quaternion.identity, AttachTo.transform);
        enemiesSpawned.Add(wolf2);

        Destroy(collisionData.CollidedWith);

        return new List<Entity>
        {
            wolf1,
            wolf2
        };
    }
}
