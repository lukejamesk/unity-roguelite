using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MovingObject
{
    public float movementInterval;

    private float count = 0;
    // Start is called before the first frame update frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        processMovement();
    }

    private void processMovement()
    {
/*        if (count > movementInterval)
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
        }*/
    }

    protected override void OnCantMove<T>(T component)
    {
        Debug.Log("Bat Cant Move");
    }
}
