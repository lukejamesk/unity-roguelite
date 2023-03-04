using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LukeKing.BattleSystem
{
    public class HealthBar : MonoBehaviour
    {
        private Image Image;
        public Actor Actor;

        private void Start()
        {
            Image = GetComponentsInChildren<Image>()[1];
        }

        void Update()
        {
            if (Actor)
            {
                gameObject.transform.position = new Vector3(Actor.transform.position.x, Actor.transform.position.y + 1, 0);
            }
        }

        public void HealthChange(HealthChangeData data)
        {
            if (Actor.GetInstanceID() == data.Actor.GetInstanceID())
            {
                var fillAmount = Mathf.Clamp01((float)data.UpdatedHealth / (float)Actor.Unit.UnitStats.Health.Value);
                Image.fillAmount = fillAmount;
            }

        }
    }
}

