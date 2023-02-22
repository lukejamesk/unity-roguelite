using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unit", menuName = "BattleSystem/Unit")]
public class Unit : ScriptableObject
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
