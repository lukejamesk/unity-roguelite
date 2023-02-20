using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public UnitStats unitStats;
    public string unitName;
    private int damageTaken;

    public int CurrentHealth()
    {
        var health = unitStats.health - damageTaken;
        return  health < 0 ? 0 : health;
    }
}
