using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggerFromEvent : MonoBehaviour
{
    public Animator animator;
    public string trigger;

    void Start()
    {
        
    }

    public void Trigger()
    {
        animator.SetTrigger(trigger);
    }

}
