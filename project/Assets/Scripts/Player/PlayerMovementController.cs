using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerMovementController : GridMovementController
{
    public float movementInterval = 2;

    public GameEvent cantMoveEvent;
    public GameEvent moveUpEvent;
    public GameEvent moveDownEvent;
    public GameEvent moveLeftEvent;
    public GameEvent moveRightEvent;
    public GameEvent movingEvent;
    public GameEvent stoppedMovingEvent;


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
                moveLeftEvent.Raise(this, null);

            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                MoveRight();
                moveRightEvent.Raise(this, null);
            }

        }
        else if (Input.GetButton("Vertical"))
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                MoveUp();
                moveUpEvent.Raise(this, null);
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                MoveDown();
                moveDownEvent.Raise(this, null);
            }

        }
    }

    protected override void OnStartMove()
    {
        movingEvent.Raise(this, null);
    }

    protected override void OnStoppedMove()
    {
       /* stoppedMovingEvent.Raise(this, null);*/
    }

    protected override void OnCantMove<T>(T component)
    {
        cantMoveEvent.Raise(this, component);
       /* if (component.GetComponent<OverworldEnemy>())
        {
            var enemy = component.GetComponent<OverworldEnemy>();
            EventBus.Trigger(EventConstants.PLAYER_ENEMY_APPROACHED, new List<OverworldEnemy> { enemy });
        }*/
    }
}
