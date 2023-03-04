using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{

    [CreateAssetMenu(fileName = "Unit", menuName = "Battle System/Unit")]
    public class Unit : ScriptableObject
    {
        public ActorSkillList SkillList;
        public ActorSkill AttackSkill;

        public UnitStats UnitStats;

    }
}

