using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    [CreateAssetMenu(fileName = "UnitStats", menuName = "Battle System/Unit Stats")]
    public class UnitStats : ScriptableObject
    {
        public IntVariable Health;
        public IntVariable Agility;
    }

}
