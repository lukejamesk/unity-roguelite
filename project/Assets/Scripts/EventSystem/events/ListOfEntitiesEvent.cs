using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "ListOfEntitiesEvent", menuName = "Events/List of Entities Event")]
public class ListOfEntitiesEvent : ArgumentGameEvent<List<Entity>> { };