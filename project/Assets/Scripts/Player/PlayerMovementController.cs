using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerMovementController : GridMovementController
{
    public float movementInterval = 2;
    private Animator animator;


    protected override void Start()
    {
        animator = GetComponent<Animator>();
        transform.position = new Vector3(.5f, .5f, 0);

        base.Start();
    }
    void Update()
    {
        if (GameManager.instance.IsInBattle())
        {
            animator.SetTrigger("playerBattleStance");
        }
        else
        {
            processMovement();
            if (IsMoving())
            {
                animator.SetTrigger("playerMove");
            }
            else
            {
                animator.ResetTrigger("playerMove");
                animator.SetTrigger("playerIdle");
            }
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
        if (component.GetComponent<Enemy>())
        {
            var enemy = component.GetComponent<Enemy>();
            EventBus.Trigger(EventConstants.PLAYER_ENEMY_APPROACHED, new List<Enemy> { enemy });
        }
    }
}
