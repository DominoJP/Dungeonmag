using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySideToSide : MonoBehaviour
{

    public Rigidbody2D RB;
    public Vector2 moveDirection;
    public float horizontalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector2(-1, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RB.MovePosition(RB.position + (moveDirection * horizontalSpeed * Time.fixedDeltaTime));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BumperLeft"))
        {
            moveDirection.x = 1;
        }

        if (other.CompareTag("BumperRight"))
        {
            moveDirection.x = -1;
        }

    }

}
