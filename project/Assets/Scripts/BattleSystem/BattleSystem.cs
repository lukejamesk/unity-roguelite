using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    [RequireComponent(typeof(EnemySpawner))]
    public class BattleSystem : MonoBehaviour
    {
        public EnemySpawner EnemySpawner;
        protected CommandMenu commandMenu;

        public List<Ally> Allies;

        public List<Actor> Participants { get; private set; }

        public List<Enemy> Enemies
        {
            get
            {
                return Participants.OfType<Enemy>().ToList();
            }
        }


        public Actor ActorTakingTurn {
            get
            {
                return Participants[CurrentTurn];
            }
        }


        OverworldInput input;

        private int CurrentTurn = 0;

        public void Start()
        {
            commandMenu = GetComponent<CommandMenu>();
        }

        public void SetupBattleFromOverworldEnemyCollision(CollisionData collisionData)
        {
            var enemiesSpawned = EnemySpawner.SpawnEnemiesFrom(collisionData);

            Participants = new List<Actor>();
            Allies.ForEach((ally) => Participants.Add(ally));
            enemiesSpawned.ForEach((enemy) => Participants.Add(enemy));

            StartCoroutine(Co_RunBattle());
        }

        private IEnumerator Co_RunBattle()
        {
            input = new OverworldInput();
            input.BattleControls.Enable();
            input.OverworldControls.Disable();

            while (!WinConditionMet())
            {
                var currentActorTurn = Participants[CurrentTurn];

                currentActorTurn.StartTurn();

                yield return new WaitWhile(() => currentActorTurn.IsTakingTurn);
                
                NextTurn();

                yield return null;
            }

        }

        private void NextTurn()
        {
            if (Participants.Count() <= CurrentTurn + 1)
            {
                CurrentTurn = 0;
            } else
            {
                CurrentTurn++;
            }
        }

        private bool WinConditionMet()
        {
            return Enemies.Find(enemy => enemy.IsAlive()) == null;
        }
    }
}

