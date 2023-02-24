using System.Collections.Generic;
using UnityEngine;

public struct EntityHealthChangeData
{
    public Entity Enemy;
    public int Health;

};
[System.Serializable]
[CreateAssetMenu(fileName = "EntityHealthChangeEvent", menuName = "Events/Entity Health Change Game Event")]
public class EntityHealthChangeEvent : ArgumentGameEvent<EntityHealthChangeData> { };