using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Events;

public struct CollisionData
{
    public GameObject CollidedWith;
};


public class PlayerMovementController : GridMovementController
{
    public float movementInterval = 2;

  /*  public GameEvent moveUpEvent;
    public GameEvent moveDownEvent;
    public GameEvent moveLeftEvent;
    public GameEvent moveRightEvent;
    public GameEvent movingEvent; 
    public GameEvent stoppedMovingEvent;*/


    public UnityEvent<CollisionData> cantMoveEvent;
    public UnityEvent<CollisionData> approachedOverworldEnemyEvent; 

    protected override void Start()
    {
       /* transform.position = new Vector3(.5f, .5f, 0);*/

        base.Start();
    }
    void Update()
    {
        processMovement();
    }

    private void processMovement()
    {
        if (Input.GetButton("Horizontal"))
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                MoveLeft();
          /*      moveLeftEvent.Raise<Null>(null);*/

            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                MoveRight();
               /* moveRightEvent.Raise<Null>(null);*/
            }

        }
        else if (Input.GetButton("Vertical"))
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                MoveUp();
               /* moveUpEvent.Raise<Null>(null);*/
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                MoveDown();
                /*moveDownEvent.Raise<Null>(null);*/
            }

        }
    }

    protected override void OnStartMove()
    {
/*        movingEvent.Raise<Null>(null);*/
    }

    protected override void OnStoppedMove()
    {
       /* stoppedMovingEvent.Raise(this, null);*/
    }

    protected override void OnCantMove<T>(T component)
    {
        cantMoveEvent.Invoke(new CollisionData
        {
            CollidedWith = component.gameObject
        });

        if (component.GetComponent<OverworldEnemy>())
        {
            approachedOverworldEnemyEvent.Invoke(new CollisionData
            {
                CollidedWith = component.gameObject
            });
        }
    }
}
