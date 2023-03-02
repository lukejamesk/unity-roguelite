using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public class CommandFetcher
    {
        private BattleSystem battleSystem;
        private CommandMenu commandMenu;
        public ICommand Command { get; private set; }

        private Ally ally;
        private TargetSystem targetSystem;

        public CommandFetcher(Ally actor)
        {
            this.ally = actor;
            battleSystem = GameObject.FindObjectOfType<BattleSystem>();
            commandMenu = GameObject.FindObjectOfType<CommandMenu>();
            targetSystem = GameObject.FindObjectOfType<TargetSystem>();

        }


        public IEnumerator Co_GetCommand()
        {
            commandMenu.EnableCommandFor(ally);

            /*while (commandMenu.SkillSelected is null)
            {
                yield return null;
            }*/


            while (Command == null)
            {
                targetSystem.GetTarget(TargetType.SingleEnemy, TargetDefault.Enemy);

                if (!(commandMenu.SkillSelected != null && targetSystem.SelectedTargets.Count > 0))
                {
                    yield return null;
                }

                if (commandMenu.SkillSelected && targetSystem.SelectedTargets.Count > 0)
                {
                    Command = new Attack(new BattleCommand
                    {
                        From = ally,
                        Skill = commandMenu.SkillSelected,
                        Targets = targetSystem.SelectedTargets
                    });
                }


                yield return null;
            }

            commandMenu.Deactivate();
            targetSystem.Deactivate();

            yield return null;
        }
    }
}