using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "EnemiesSpawnedEvent", menuName = "Enemies Spawned Event")]
public class EnemiesSpawnedEvent : ArgumentGameEvent<List<Unit>> { };