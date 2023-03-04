using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace LukeKing.BattleSystem
{
    public class Attack : ICommand
    {
        private Vector3 initialPosition;
        private Actor attacker;
        private List<Actor> targets;
        private ActorSkill skill;

        public bool IsFinished { get; private set; } = false;

        public Attack(BattleCommand battleCommand)
        {
            attacker = battleCommand.From;
            this.targets = battleCommand.Targets;
            this.skill = battleCommand.Skill;

            initialPosition = battleCommand.From.transform.position;
        }

        public IEnumerator Co_Execute()
        {
            Debug.Log("Attacking with");
            Debug.Log(skill.Name);

            var target = targets[0];
            var targetPosition = target.FrontTargetPosition();
            while (attacker.transform.position != targetPosition)
            {
                attacker.transform.position = Vector2.MoveTowards(attacker.transform.position, targetPosition, .5f);
                yield return null;
            }

            yield return new WaitForSecondsRealtime(.5f);

            targets.ForEach(target => target.TakeDamage(CalculateAttack(target)));

            yield return new WaitForSecondsRealtime(.5f);

            while (attacker.transform.position != initialPosition)
            {
                attacker.transform.position = Vector2.MoveTowards(attacker.transform.position, initialPosition, .5f);
                yield return null;
            }


            yield return new WaitForSecondsRealtime(.5f);

            IsFinished = true;
        }

        private int CalculateAttack(Actor defender)
        {
            return skill.BaseDamage;
        }
    }
}
