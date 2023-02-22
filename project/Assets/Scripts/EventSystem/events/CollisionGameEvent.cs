using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "CollisionGameEvent", menuName = "Events/Collision Game Event")]
public class CollisionGameEvent : ArgumentGameEvent<CollisionData> { };