using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class GridMovementController : MonoBehaviour, IMovementController
{
    private Rigidbody2D rb2D;
    private BoxCollider2D boxCollider;
    private float inverseMoveTime;
    public float moveTime = .1f;

    private bool isMoving = false;

    protected IEnumerator SmoothMovement(Vector3 end)
    {
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;
        while (sqrRemainingDistance > float.Epsilon)
        {
            Vector3 newPosition = Vector3.MoveTowards(rb2D.position, end, inverseMoveTime * Time.deltaTime);
            rb2D.MovePosition(newPosition);
            sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            yield return null;
        }
        isMoving = false;
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1f / moveTime;
    }

    public bool IsMoving()
    {
        return isMoving;
    }

    public bool Move(int xDir, int yDir, out RaycastHit2D hit)
    {
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(xDir, yDir);

        boxCollider.enabled = false;

        hit = Physics2D.Linecast(start, end);
        Debug.DrawLine(start, end, Color.white, 2.5f);
        boxCollider.enabled = true;


        if (!hit.collider?.GetComponent<MovementBlockableObject>())
        {
            StartCoroutine(SmoothMovement(end));
            return true;
        }


        isMoving = false;

        return false;

    }

    protected virtual void AttemptMove<T>(int xDir, int yDir) where T : Component
    {
        if (!isMoving)
        {
            isMoving = true;
            RaycastHit2D hit;
            bool canMove = Move(xDir, yDir, out hit);
            if (canMove)
            {
                return;
            }

            T hitComponent = hit.transform.GetComponent<T>();
            if (!canMove && hitComponent != null)
            {
                OnCantMove<T>(hitComponent);
            }
        }
    }

    protected abstract void OnCantMove<T>(T component) where T : Component;

    public void MoveLeft()
    {
        AttemptMove<MovementBlockableObject>(-1, 0);
    }

    public void MoveRight()
    {
        AttemptMove<MovementBlockableObject>(1, 0);
    }
    public void MoveUp()
    {
        AttemptMove<MovementBlockableObject>(0, -1);

    }
    public void MoveDown()
    {
        AttemptMove<MovementBlockableObject>(0, 1);
    }
}
