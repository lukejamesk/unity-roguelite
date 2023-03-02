using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public class TargetSystem : MonoBehaviour
    {
        public event Action<Actor> CurrentlyTargeting;
        public void NotifyTargetChange(Actor actor) => CurrentlyTargeting?.Invoke(actor);

        public TargetIndicator TargetIndicatorPrefab;

        private BattleSystem battleSystem;
        public List<Actor> ValidTargets;
        private List<Actor> selectedTargets = new List<Actor>();

        public List<Actor> SelectedTargets => selectedTargets;

        public bool IsFindingTarget { get; private set; }


        private TargetIndicator targetIndicator = null;

        void Start()
        {
            battleSystem = GetComponentInParent<BattleSystem>();
        }

        // Update is called once per frame
        void Update()
        {
            if (IsFindingTarget)
            {
                if (Input.GetButtonUp("Horizontal"))
                {
                    if (Input.GetAxis("Horizontal") < 0)
                    {
                        MovePrevious();
                    }
                    else
                    {
                        MoveNext();
                    }
                }
            }

        }

        public void Deactivate()
        {
            IsFindingTarget = false;
            targetIndicator.gameObject.SetActive(false);
        }

        public void GetTarget (TargetType targetType, TargetDefault targetDefault)
        {
            IsFindingTarget = true;

            ValidTargets = battleSystem.Participants.OfType<Enemy>().Cast<Actor>().ToList();

            if (targetIndicator != null)
            {
                targetIndicator.gameObject.SetActive(true);
            }

            switch (targetType)
            {
                case TargetType.SingleEnemy:
                    GetAnySingleTarget(targetDefault);
                    break;
                default:
                    Debug.LogWarning("Target type not yet implemented");
                break;

            }
        }

        private void GetAnySingleTarget(TargetDefault targetDefault)
        {
            switch (targetDefault)
            {
                case TargetDefault.Enemy:
                    var enemyPositionIndicator = new Vector3(ValidTargets[0].transform.position.x, battleSystem.Enemies[0].transform.position.y + 1, 0);
                    if (targetIndicator == null)
                    {
                        targetIndicator = Instantiate(TargetIndicatorPrefab, enemyPositionIndicator, Quaternion.identity, battleSystem.Enemies[0].transform);
                        selectedTargets = new List<Actor>()
                        {
                            ValidTargets[0]
                        };
                    }
                    break;
                default:
                    Debug.LogWarning("Target default not yet implemented");
                    break;
            }
        }

        private void MoveNext()
        {
            var indexOfCurrent = selectedTargets.Count > 0 ? ValidTargets.IndexOf(selectedTargets[0]) : ValidTargets.Count;
            var lengthOfTargets = ValidTargets.Count - 1;
            var nextIndex = indexOfCurrent >= lengthOfTargets ? 0 : indexOfCurrent + 1;

            selectedTargets = new List<Actor>()
            {
                ValidTargets[nextIndex]
            };

            NotifyTargetChange(ValidTargets[nextIndex]);
        }
        private void MovePrevious()
        {
            var indexOfCurrent = selectedTargets.Count > 0 ? ValidTargets.IndexOf(selectedTargets[0]) : ValidTargets.Count;
            var lengthOfTargets = ValidTargets.Count - 1;
            var nextIndex = indexOfCurrent == 0 ? lengthOfTargets : indexOfCurrent - 1;

            selectedTargets = new List<Actor>()
            {
                ValidTargets[nextIndex]
            };

            NotifyTargetChange(ValidTargets[nextIndex]);
        }
    }
}