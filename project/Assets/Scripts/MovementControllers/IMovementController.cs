using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementController
{
    public bool Move(int xDir, int yDir, out RaycastHit2D hit);

    public bool IsMoving();
    public void MoveLeft();
    public void MoveRight();
    public void MoveUp();
    public void MoveDown();
}
