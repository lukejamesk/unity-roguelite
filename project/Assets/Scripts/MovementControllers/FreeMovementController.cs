using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public struct CollisionData
{
    public GameObject CollidedFrom;
    public GameObject CollidedWith;
};

[RequireComponent(typeof(Rigidbody2D))]
public class FreeMovementController : MonoBehaviour
{

    public UnityEvent<CollisionData> cantMoveEvent;
    public UnityEvent<CollisionData> approachedOverworldEnemyEvent;

    private OverworldInput overworldInput;
    private Rigidbody2D rb;

    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float gravityValue = -9.81f;

    Vector2 movement;
    private Vector3 playerVelocity;

    private float collisionOffset = 1.3f;

    public ContactFilter2D movementFilter;



    private void Awake()
    {
        overworldInput = new OverworldInput();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (overworldInput.OverworldControls.Movement.IsPressed())
        {
            movement = overworldInput.OverworldControls.Movement.ReadValue<Vector2>();
        } else
        {
            movement = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        bool success = MovePlayer(movement);

        if (!success)
        {
            success = MovePlayer(new Vector2(movement.x, 0));

            if (!success)
            {

                MovePlayer(new Vector2(0, movement.y));
            }
        }
    }
    private void OnEnable()
    {
        overworldInput.Enable();
    }

    private void OnDisable()
    {
        overworldInput.Disable();
    }

    private bool MovePlayer(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
            int count = rb.Cast(
                direction,
                movementFilter,
                castCollisions,
                movementSpeed * Time.fixedDeltaTime * collisionOffset
            );

            if (count == 0)
            {
                Vector2 moveVector = direction * movementSpeed * Time.fixedDeltaTime;
                rb.MovePosition(rb.position + moveVector);
                return true;
            } else
            {
                castCollisions.ForEach(rayCastHit =>
                {
                    OnCantMove(rayCastHit.collider.gameObject);
                });
                return false;
            }
        }

        return true;
    }

    private void OnCantMove(GameObject collidedWithObject)
    {

        Debug.Log("Invoked blockable object collision");
        cantMoveEvent.Invoke(new CollisionData
        {
            CollidedFrom = gameObject,
            CollidedWith = collidedWithObject
        });

        if (collidedWithObject.GetComponent<OverworldEnemy>())
        {
            Debug.Log("Invoked enemy collision");
            approachedOverworldEnemyEvent.Invoke(new CollisionData
            {
                CollidedFrom = gameObject,
                CollidedWith = collidedWithObject.gameObject
            }); ;
        }
    }

}
