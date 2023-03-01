using System;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{

    [CreateAssetMenu(fileName = "ActorSkill", menuName = "Battle System/Actor Skill")]
    public class ActorSkill : ScriptableObject
    {
        public string Name;
        public int BaseDamage;
    }
}
