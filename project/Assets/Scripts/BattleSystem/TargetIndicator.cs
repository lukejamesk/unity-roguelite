using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public class TargetIndicator : MonoBehaviour
    {
        private TargetSystem targetSystem;
        private List<Actor> targets;
        private Actor CurrentSelection;
        private Transform selectorTransform;

        private void Awake()
        {
            targetSystem = FindObjectOfType<TargetSystem>();
            selectorTransform = GetComponent<Transform>();
        }

        private void Start()
        {
            targets = targetSystem.ValidTargets;

            targetSystem.CurrentlyTargeting += SetTarget;
        }

        private void Update()
        {
        /*    if (Input.GetButtonUp ("Horizontal"))
            {
                if (Input.GetAxis("Horizontal") < 0)
                {
                    StartCoroutine(Co_MovePrevious());
                }
                else
                {
                    StartCoroutine(Co_MoveNext());
                }
            }*/
        }


/*        private IEnumerator Co_MovePrevious()
        {
            Debug.Log(CurrentSelection);
            CurrentSelection = CurrentSelection == 0 ? targets.Count - 1 : CurrentSelection - 1;
            Debug.Log(CurrentSelection);

            SetTarget();
            yield return null;
        }

        private IEnumerator Co_MoveNext()
        {
            Debug.Log(CurrentSelection);
            CurrentSelection = CurrentSelection >= targets.Count - 1 ? 0 : CurrentSelection + 1;
            Debug.Log(CurrentSelection);

            SetTarget();
            yield return null;
        }*/

        private void SetTarget(Actor actor) {
            CurrentSelection = actor;
            var currentTargetPosition = CurrentSelection.transform.position;
            selectorTransform.SetParent(CurrentSelection.transform);
            selectorTransform.position = new Vector3(currentTargetPosition.x, currentTargetPosition.y + 1, 0);
        }
    }
}

