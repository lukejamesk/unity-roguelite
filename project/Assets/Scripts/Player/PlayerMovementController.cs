using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerMovementController : GridMovementController
{
    public float movementInterval = 2;

    protected override void Start()
    {
        transform.position = new Vector3(.5f, .5f, 0);

        base.Start();
    }
    void Update()
    {
        if (GameManager.instance.IsInBattle())
        {
        }
        else
        {
            processMovement();
        }
    }

    private void processMovement()
    {
        if (Input.GetButton("Horizontal"))
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                MoveLeft();
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                MoveRight();
            }

        }
        else if (Input.GetButton("Vertical"))
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                MoveUp();
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                MoveDown();
            }

        }
    }
    
    protected override void OnCantMove<T>(T component)
    {
        if (component.GetComponent<OverworldEnemy>())
        {
            var enemy = component.GetComponent<OverworldEnemy>();
            EventBus.Trigger(EventConstants.PLAYER_ENEMY_APPROACHED, new List<OverworldEnemy> { enemy });
        }
    }
}
