using System.Collections.Generic;
using UnityEngine;
using LukeKing.BattleSystem;

public struct HealthChangeData
{
    public Actor Actor;
    public int UpdatedHealth;
    public int DamageTaken;
}


[System.Serializable]
[CreateAssetMenu(fileName = "HealthChangeEvent", menuName = "Events/Health Change Event")]
public class HealthChangeEvent : ArgumentGameEvent<HealthChangeData> { };