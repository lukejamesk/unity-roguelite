using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{

    public static BattleSystem instance = null;
    public EnemySpawner enemySpawner;
    public PlayerCharacter playerCharacter;
    private IEnumerable<Enemy> enemies;
    private IEnumerable<Unit> turnOrder;

 

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {

    }

    void Update()
    {
    }

    public IEnumerator InitializeBattle(List<OverworldEnemy> overworldEnemies)
    {
        var spawnedEnemies = new List<Enemy>();
        overworldEnemies.ForEach(
            overworldEnemy => enemySpawner
                .SpawnEnemiesFrom(overworldEnemy)
        );

        spawnedEnemies.ForEach(spawnedEnemy => AddEnemyToBattle(spawnedEnemy));

        /*       SetTurnOrder(CalculateTurnOrder());*/

        yield return null;
    }

    private void AddEnemyToBattle(Enemy enemy)
    {
        enemies = enemies.Concat(new List<Enemy>() { enemy });
    }
                          
/*    private void SetTurnOrder(IEnumerable<Unit> newTurnOrder)
    {
        turnOrder = newTurnOrder;
    }

    private IEnumerable<Unit> CalculateTurnOrder()
    {
        return Units().OrderBy(unit => unit.unitStats.speed);
    }

    private IEnumerable<Unit> Units()
    {
          return enemies.Select(enemy => enemy.gameObject.GetComponent<Unit>()).Concat(new List<Unit>() { playerCharacter.gameObject.GetComponent<Unit>() });
    }*/
}
