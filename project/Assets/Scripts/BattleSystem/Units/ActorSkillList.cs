using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    [CreateAssetMenu(fileName = "ActorSkillList", menuName = "Battle System/Actor Skill List")]
    public class ActorSkillList : ScriptableObject
    {
        public List<ActorSkill> skillList;
    }
}