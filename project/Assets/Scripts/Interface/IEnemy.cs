using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy : IMovementBlockable
{
    int health { get; set; }
    void BeginBattle();
}
