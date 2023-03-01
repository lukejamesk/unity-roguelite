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

        private Actor actor;
        public CommandFetcher(Actor actor)
        {
            this.actor = actor;
            battleSystem = GameObject.FindObjectOfType<BattleSystem>();
            commandMenu = GameObject.FindObjectOfType<CommandMenu>();

        }
        /*    public void GetCommand() => StartCoroutine(Co_GetCommand());
            }*/

        public IEnumerator Co_GetCommand()
        {
            commandMenu.EnableCommandFor(actor);

            while (commandMenu.SkillSelected is null)
            {
                yield return null;
            }

            Debug.Log(commandMenu.SkillSelected);

            Command = new Attack(new BattleCommand
            {
                From = actor,
                Skill = commandMenu.SkillSelected,
                Targets = new List<Actor>() { battleSystem.Enemies[0] }
            });

            commandMenu.Deactivate();
            while (Command == null)
            {
                yield return null;
            }
            /*while (Command == null)
            {
                var targets = new List<Actor>() { battleSystem.Enemies[0] };
                Command = new Attack(actor, targets);

                yield return null;
            }*/

            yield return null;
        }
    }
}