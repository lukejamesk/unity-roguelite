using System;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public class RandomTargetAndSkillAI : EnemyAI
    {
        protected override void Awake()
        {
            base.Awake();
        }

        public override void ChooseAction()
        {
            Command = new Attack(new BattleCommand
            {
                From = self,
                Skill = self.Unit.SkillList.skillList[0],
                Targets = new List<Actor>() { battleSystem.Allies[0] }
            });
        }
    }
}
