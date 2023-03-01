using System;
using System.Collections.Generic;
using UnityEngine;

namespace LukeKing.BattleSystem
{
    public abstract class EnemyAI : MonoBehaviour
    {
        protected BattleSystem battleSystem { get; private set; }
        protected Actor self { get; private set; }

        public ICommand Command { get; protected set; }

        protected virtual void Awake()
        {
            battleSystem = FindObjectOfType<BattleSystem>();
            self = GetComponent<Actor>();
        }

        public abstract void ChooseAction();
    }
}
