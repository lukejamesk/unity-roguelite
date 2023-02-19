using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveable
{
    IMovementController movementController { get; set; }
}
