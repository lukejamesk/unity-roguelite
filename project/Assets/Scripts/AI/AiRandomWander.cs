using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AiRandomWander : GridMovementController, IEnemy
{
    public float movementInterval = 2;

    private float count;


    protected override void Start()
    {
        base.Start();
    }
    void Update()
    {
        count += Time.deltaTime;
        processMovement();
    }

    private void processMovement()
    {
        if (count > movementInterval)
        {
            string[] movementDirections = new[] { "right", "left", "up", "down" };
            string movementDirection = movementDirections[Random.Range(0, movementDirections.Length)];

            switch (movementDirection)
            {
                case "up":
                    moveUp();
                    break;
                case "down":
                    moveDown();
                    break;
                case "left":
                    moveLeft();
                    break;
                case "right":
                    moveRight();
                    break;
            }
            count = 0;
        }
    }

    protected override void OnCantMove<T>(T component)
    {
        Debug.Log("Bat Cant Move");
    }
}
