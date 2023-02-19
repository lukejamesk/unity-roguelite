using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MovementBlockableObject, IEnemy
{
    public float movementInterval;

    private int _health = 100;
    public int health { get => _health; set => _health = health; }

    public AiRandomWander aiMovement;

    void Awake()
    {
        aiMovement = this.GetComponent<AiRandomWander>();
    }


    void Update()
    {
    }

    private void processMovement()
    {
    }

    public void BeginBattle()
    {
        aiMovement.Disable();
    }
}
