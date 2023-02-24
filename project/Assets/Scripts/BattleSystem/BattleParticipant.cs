using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class BattleParticipant
{
    public int Speed;
    public int TickCounter;
    public int TickSpeed;
    public int Id;

    public BattleParticipant(int tickCounter, int tickSpeed, int speed, int id)
    {
        Speed = speed;
        TickCounter = tickCounter;
        TickSpeed = tickSpeed;
        Id = id;
    }



    public int CalculateTurnTick(int tickCounter)
    {
        return tickCounter - (TickSpeed + Speed);

    }
    public bool TickTurn()
    {
        TickCounter = CalculateTurnTick(TickCounter);
        if (TickCounter <= 0)
        {
            TickCounter = 100;
            return true;
        }
        return false;
    }

}