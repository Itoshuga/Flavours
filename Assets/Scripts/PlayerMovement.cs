using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rB;
    private Vector2 movementPosition;

    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementPosition = Vector2.zero;
        movementPosition.x = Input.GetAxisRaw("Horizontal");
        movementPosition.y = Input.GetAxisRaw("Vertical");

        rB.MovePosition(rB.position + movementPosition.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
