using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (GameManager.instance.isInBattle())
        {
            animator.SetTrigger("playerBattleStance");
        }
        else
        {
            processMovement();
            if (isMoving())
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
                moveLeft();
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                moveRight();
            }

        }
        else if (Input.GetButton("Vertical"))
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                moveUp();
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                moveDown();
            }

        }
    }
    
    protected override void OnCantMove<T>(T component)
    {
        if (component.GetComponent<Enemy>())
        {
            var enemies = new List<T> { component };
            GameManager.instance.BeginBattle<T>(enemies);
            Debug.Log("Approached enemy");
        }
    }
}
