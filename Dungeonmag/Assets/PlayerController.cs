using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D RB;
    Vector2 moveDirection;
    public bool hasGun;
    public float health;
    

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {

        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {

        RB.MovePosition(RB.position + (moveDirection * moveSpeed * Time.fixedDeltaTime));

    }

}
