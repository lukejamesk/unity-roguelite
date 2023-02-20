using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class OverworldEnemy : MovementBlockableObject, IOverworldEnemy
{
    private AiRandomWander aiMovement;

    void Awake()
    {
        aiMovement = GetComponent<AiRandomWander>();
    }


    void Update()
    {
    }

    public void BeginBattle()
    {
        aiMovement.Disable();
    }
}
