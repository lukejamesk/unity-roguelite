using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

namespace LukeKing.BattleSystem
{
    [RequireComponent(typeof(Button))]
    public class ActionButton : MonoBehaviour
    {
        public Button Button { get; private set; }
        public ActorSkill Skill;
        public string ShortcutKey;
        private System.Action<ActorSkill> callbackOnClick;

        public TextMeshProUGUI ShortcutText;

        public TextMeshProUGUI NameText;

        private OverworldInput input;

        private void Awake()
        {
            input = new OverworldInput();
        }

        private void Start()
        {
            Button = gameObject.GetComponent<Button>();

            Button.onClick.AddListener(delegate
            {
                callbackOnClick(Skill);
            });


        }

        private void OnEnable()
        {
            input.BattleControls.action.Enable();
            input.BattleControls.action.performed += (ctx) => {
                Debug.Log(ctx);
                Button.onClick.Invoke();
            };
        }

        private void OnDisable()
        {
            input.BattleControls.action.Disable();
        }

        private void Update()
        {
            if (ShortcutText.text != ShortcutKey)
            {
                ShortcutText.text = ShortcutKey;
            }

            if (NameText.text != Skill.Name)
            {
                NameText.text = Skill.Name;
            }
        }
        public void OnSelect(System.Action<ActorSkill> callback) 
        {
            callbackOnClick = callback;
        }
    }

}

