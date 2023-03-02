using System;
using System.Collections;
using UnityEngine;
namespace LukeKing.BattleSystem
{
    public class Ally : Actor
    {
        public override void StartTurn()
        {
            IsTakingTurn = true;
            StartCoroutine(Co_GetPlayerCommand());
        }

        private IEnumerator Co_GetPlayerCommand()
        {
            CommandFetcher commandFetcher = new CommandFetcher(this);

            StartCoroutine(commandFetcher.Co_GetCommand());
            while (commandFetcher.Command == null)
            {
                yield return null;
            }

            StartCoroutine(commandFetcher.Command.Co_Execute());

            yield return new WaitUntil(() => commandFetcher.Command.IsFinished);

            IsTakingTurn = false;
        }

        public override Vector3 FrontTargetPosition()
        {
            return new Vector3(transform.position.x - 1, transform.position.y);
        }

        public override Vector3 BackTargetPosition()
        {
            return new Vector3(transform.position.x + 1, transform.position.y);
        }
    }

}
