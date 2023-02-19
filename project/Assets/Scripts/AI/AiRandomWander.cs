using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AiRandomWander : GridMovementController, IAi
{
    public float movementInterval = 2;

    private float count;

    private bool disabled = false;

    protected override void Start()
    {
        base.Start();
    }
    void Update()
    {
        if (!disabled)
        {
            count += Time.deltaTime;
            ProcessMovement();
        }
        
    }

    private void ProcessMovement()
    {
        if (count > movementInterval)
        {
            string[] movementDirections = new[] { "right", "left", "up", "down" };
            string movementDirection = movementDirections[Random.Range(0, movementDirections.Length)];

            switch (movementDirection)
            {
                case "up":
                    MoveUp();
                    break;
                case "down":
                    MoveDown();
                    break;
                case "left":
                    MoveLeft();
                    break;
                case "right":
                    MoveRight();
                    break;
            }
            count = 0;
        }
    }

    protected override void OnCantMove<T>(T component)
    {
    }

    public void Disable()
    {
        disabled = true;
    }
}
