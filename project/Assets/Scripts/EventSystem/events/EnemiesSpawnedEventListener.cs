using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("Game Events/Enemies Spawned Event Listener")]
[System.Serializable]
public class EnemiesSpawnedEventListener : ArgumentGameEventListener<List<Unit>> { };