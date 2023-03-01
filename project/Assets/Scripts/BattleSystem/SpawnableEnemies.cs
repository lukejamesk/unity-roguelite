using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    [CreateAssetMenu(fileName = "Spawnable Enemies", menuName = "Battle System/Spawnable Enemies")]
    public class SpawnableEnemies : ScriptableObject
    {
        public List<Enemy> enemies;
    }
}

