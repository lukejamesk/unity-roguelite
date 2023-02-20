using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Enemy> spawnableEnemies;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Enemy> SpawnEnemiesFrom(OverworldEnemy enemy)
    {
        var enemiesSpawned = new List<Enemy>();
        Vector3 location = enemy.gameObject.transform.position;
        enemiesSpawned.Add(Instantiate(spawnableEnemies[0], location, Quaternion.identity));
        enemiesSpawned.Add(Instantiate(spawnableEnemies[0], new Vector3(location.x - 1, location.y + 1), Quaternion.identity));

        Destroy(enemy.gameObject);

        return enemiesSpawned;
    }
}
