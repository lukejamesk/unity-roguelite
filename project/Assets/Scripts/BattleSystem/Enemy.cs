using System;
using System.Collections;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public class Enemy : Actor
    {
        private EnemyAI ai;

        protected override void Awake()
        {
            base.Awake();
            ai = GetComponent<EnemyAI>();
        }

        public override void StartTurn()
        {
            if (IsAlive())
            {
                IsTakingTurn = true;
                StartCoroutine(Co_TakeTurn());
            }
        }

        private IEnumerator Co_TakeTurn()
        {
            ai.ChooseAction();

            StartCoroutine(ai.Command.Co_Execute());

            yield return new WaitUntil(() => ai.Command.IsFinished);

            IsTakingTurn = false;
        }


        public override Vector3 FrontTargetPosition()
        {
            return new Vector3(transform.position.x + 1, transform.position.y);
        }

        public override Vector3 BackTargetPosition()
        {
            return new Vector3(transform.position.x - 1, transform.position.y);
        }
    }

}
