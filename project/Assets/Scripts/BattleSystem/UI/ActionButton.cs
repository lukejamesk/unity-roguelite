using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

        private void Start()
        {
            Button = gameObject.GetComponent<Button>();

            Button.onClick.AddListener(delegate
            {
                callbackOnClick(Skill);
            });
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

            if (Input.GetKey(ShortcutKey))
            {
                Button.onClick.Invoke();
            }
        }
        public void OnSelect(System.Action<ActorSkill> callback) 
        {
            callbackOnClick = callback;
        }
    }

}

