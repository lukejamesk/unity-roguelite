using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LukeKing.BattleSystem
{
    public class CommandMenu : MonoBehaviour
    {
        [SerializeField]
        private ActionButton ActionButton;

        [HideInInspector]
        public bool IsSelecting { get; private set; }

        private Actor CurrentActor;

        [HideInInspector]
        public ActorSkill SkillSelected { get; private set; } = null;


        private RectTransform Rect;
        private float inactiveYPosition;
        private float activeYPosition;

        private float currentYPosition => Rect.anchoredPosition.y;

        private List<ActionButton> actionButtonsCreated;

        void Awake()
        {
            Rect = GetComponent<RectTransform>();

            activeYPosition = Rect.anchoredPosition.y;

            inactiveYPosition = Rect.anchoredPosition.y + 3000f;


            Rect.anchoredPosition = new Vector2(Rect.anchoredPosition.x, inactiveYPosition);
        }

        public void Update()
        {
           
        }

        public void EnableCommandFor(Actor actor) {
            CurrentActor = actor;
            StartCoroutine(Co_ChooseCommand());
        }

        private IEnumerator Co_ChooseCommand()
        {
            IsSelecting = true;

            SetupMenu();

            while (SkillSelected == null)
            {
                yield return null;
            }

            CurrentActor = null;

            yield return null;
        }

        private void SetupMenu()
        {
            actionButtonsCreated = new List<ActionButton>();
            CurrentActor.skillList.skillList.ForEach((skill) =>
            {
                var Button = Instantiate(ActionButton, gameObject.transform.position, Quaternion.identity, gameObject.transform);
                Button.Skill = skill;
                Button.OnSelect(ActionSelected);

                actionButtonsCreated.Add(Button);
            });

            if (IsSelecting && currentYPosition != activeYPosition)
            {
                Rect.anchoredPosition = new Vector2(Rect.anchoredPosition.x, activeYPosition);
            }
        }

        public void Deactivate()
        {
            SkillSelected = null;
            IsSelecting = false;

            if (!IsSelecting && currentYPosition != inactiveYPosition)
            {
                Rect.anchoredPosition = new Vector2(Rect.anchoredPosition.x, inactiveYPosition);
            }

            actionButtonsCreated.ForEach(button => Destroy(button.gameObject));
        }


        public void ActionSelected(ActorSkill skill)
        {
            SkillSelected = skill;
        }
    }
}

