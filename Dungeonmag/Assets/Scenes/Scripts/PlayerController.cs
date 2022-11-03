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
    public float maxHealth;

    public HealthBarController healthBarScript;

    void Start()
    {
        health = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
        healthBarScript.UpdateHealth(health);

        if (health <= 0f)
        {
            killPlayer();
        }


        if(health > maxHealth)
        {
            health = maxHealth;
        }

    }

    private void killPlayer()
    {
        //???
    }

    private void FixedUpdate()
    {

        RB.MovePosition(RB.position + (moveDirection * moveSpeed * Time.fixedDeltaTime));

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health = health - 1;
        }
    }

}
