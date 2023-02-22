using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unit", menuName = "BattleSystem/Unit")]
public class Unit : ScriptableObject
{
    public UnitStats unitStats;
    public IntReference Health;
    public IntReference MaxHealth;
    public string unitName;
}
