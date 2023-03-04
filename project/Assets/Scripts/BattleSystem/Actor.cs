using System;
using UnityEngine;
using UnityEngine.Events;
namespace LukeKing.BattleSystem
{
    public abstract class Actor : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent<HealthChangeData> healthChangeEvent;

        public Unit Unit;
        protected Vector2 startingPosition;
        public bool IsTakingTurn { get; protected set; }

        [HideInInspector]
        public int CurrentHealth { get; private set; }

        protected virtual void Start()
        {
            startingPosition = transform.position;
        }

        protected virtual void Awake()
        {
            CurrentHealth = Unit.UnitStats.Health.Value;
        }

        public bool IsAlive()
        {
            return CurrentHealth > 0;
        }

        public void TakeDamage(int damage)
        {
            var newHealth = CurrentHealth - damage;
            CurrentHealth = newHealth < 0 ? 0 : newHealth;

            healthChangeEvent.Invoke(new HealthChangeData()
            {
                Actor = this,
                DamageTaken = damage,
                UpdatedHealth = CurrentHealth,
            });
        }

        public abstract void StartTurn();
        public abstract Vector3 FrontTargetPosition();
        public abstract Vector3 BackTargetPosition();
    }

}
