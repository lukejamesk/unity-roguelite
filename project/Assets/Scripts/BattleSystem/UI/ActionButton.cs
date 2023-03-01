using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LukeKing.BattleSystem
{
    [RequireComponent(typeof(Button))]
    public class ActionButton : MonoBehaviour
    {
        public Button Button { get; private set; }
        public ActorSkill Skill;
        private System.Action<ActorSkill> callbackOnClick;

        private void Start()
        {
            Button = gameObject.GetComponent<Button>();

            Button.onClick.AddListener(delegate
            {
                callbackOnClick(Skill);
            });
        }

        public void OnSelect(System.Action<ActorSkill> callback) 
        {
            callbackOnClick = callback;
        }
    }

}

