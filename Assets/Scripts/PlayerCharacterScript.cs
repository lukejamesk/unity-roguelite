using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterScript : MovingObject
{
    private Animator animator;
    // Start is called before the first frame update
    protected override void Start()
    {
        animator = GetComponent<Animator>();
        transform.position = new Vector3(.5f, .5f, 0);

        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isInBattle()) {
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
        } else
        {
            animator.SetTrigger("playerBattleStance");

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

        } else if (Input.GetButton("Vertical"))
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


 
    protected override void AttemptMove <T> (int xDir, int yDir)
    {
        base.AttemptMove<T>(xDir, yDir);
    }

    protected override void OnCantMove<T>(T component)
    {
        Debug.Log(component.gameObject.layer);
        if (component.gameObject.layer == Constants.LAYER_ENEMY)
        {
            var enemies = new List<T> { component };
            GameManager.instance.BeginBattle<T>(enemies);
            Debug.Log("Approached enemy");
        }
        Debug.Log("Cant Move");
    }

}
