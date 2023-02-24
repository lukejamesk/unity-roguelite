using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;
public class Entity : MonoBehaviour
{
    public Unit Unit;

    public UnityEvent<EntityHealthChangeData> EntityHealthChangedEvent;

    private int Health { get; set; }

    public int TickCounter = 100;
    public int TickSpeed = 5;

    [HideInInspector]
    public BattleParticipant battleParticipant;

    void Start()
    {
    }
    private void Awake()
    {
        Health = Unit.Health.Value;
        TriggerHealthChangeEvent();
        battleParticipant = new BattleParticipant(TickCounter, TickSpeed, Unit.unitStats.speed, GetInstanceID());
    }

    private void TriggerHealthChangeEvent ()
    {
        EntityHealthChangedEvent.Invoke(new EntityHealthChangeData
        {
            Enemy = this,
            Health = Health
        });

    }

    public void DealDamage(int amount)
    {
        var newHealth = Health - amount;
        Health = newHealth < 0 ? 0 : newHealth;

        TriggerHealthChangeEvent();
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

/*    public int TicksUntilAction()
    {
        var turns = 0;
        var currentTickCounter = TickCounter;
        while (currentTickCounter > 0)
        {
            currentTickCounter = CalculateTurnTick(currentTickCounter);
            turns++;
        }

        return turns;
    }*/
}
