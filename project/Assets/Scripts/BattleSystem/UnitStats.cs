using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "UnitStats", menuName = "BattleSystem/Unit Stats")]
public class UnitStats : ScriptableObject
{
    public int health;
    public int speed;
    public int strength;

}
