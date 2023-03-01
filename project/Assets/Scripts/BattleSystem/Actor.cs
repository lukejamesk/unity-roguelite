using System;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public abstract class Actor : MonoBehaviour
    {
        public ActorSkillList skillList;
        protected Vector2 startingPosition;
        public bool IsTakingTurn { get; protected set; }

        public int Health;

        protected virtual void Start()
        {
            startingPosition = transform.position;
        }

        protected virtual void Awake()
        {

        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public abstract void StartTurn();
        public abstract Vector3 FrontTargetPosition();
        public abstract Vector3 BackTargetPosition();
    }

}
