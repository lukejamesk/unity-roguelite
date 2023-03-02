using System.Collections;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public enum TargetType
    {
        SingleEnemy = 0,
        GroupEnemy = 1,
        SingleAlly = 2,
        GroupAlly = 3,
        GroupAll = 4,
    }

    public enum TargetDefault
    {
        Ally = 0,
        Enemy = 1,
    }
}