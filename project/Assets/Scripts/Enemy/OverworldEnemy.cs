using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class OverworldEnemy : MovementBlockableObject
{
/*    private AiRandomWander aiMovement;*/

    void Awake()
    {
   /*     aiMovement = GetComponent<AiRandomWander>();*/
    }


    void Update()
    {
    }

    public void BeginBattle()
    {
/*        aiMovement.Disable();*/
    }
}
