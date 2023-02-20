using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy : IMovementBlockable
{
    public int health { get; set; }
}
