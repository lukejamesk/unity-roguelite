using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    private Animator animator;
    void Start()
    { 
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.instance.IsInBattle())
        {
        }
        else
        {
            if (gameObject.transform.parent.gameObject.GetComponent<PlayerMovementController>().IsMoving())
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
}
