using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spawnable Enemies", menuName = "BattleSystem/Spawnable Enemies")]
public class SpawnableEnemies : ScriptableObject
{
    public List<Entity> enemies;
}
