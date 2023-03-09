using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace LukeKing.BattleSystem
{
    public class DamageIndicator : MonoBehaviour
    {
        private TextMeshProUGUI text;
        private float disapearTime = 1f;
        private float timeCount;
        private bool showingDamage;
        private Actor actor;

        void Start()
        {
            gameObject.SetActive(false);
            text = GetComponentInChildren<TextMeshProUGUI>();
            actor = GetComponentInParent<Actor>();
        }

        // Update is called once per frame
        void Update()
        {
            if (showingDamage)
            {
                if (timeCount < disapearTime)
                {
                    timeCount = timeCount + Time.deltaTime;
                } else
                {
                    timeCount = 0;
                    gameObject.SetActive(false);
                }
            }
        }

        private void SetDamage(int amount)
        {
            text.text = amount.ToString();
            showingDamage = true;
            gameObject.SetActive(true);
        }

        public void OnHealthUpdate(HealthChangeData healthChangeData)
        {
            if (healthChangeData.Actor == actor)
            {
                SetDamage(healthChangeData.DamageTaken);
            }
        }
    }

}
