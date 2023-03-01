using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeKing.BattleSystem
{
    public struct BattleCommand
    {
        public ActorSkill Skill;
        public Actor From;
        public List<Actor> Targets;
    }
}
