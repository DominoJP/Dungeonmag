using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D RB;
    Vector2 moveDirection;
    public bool hasGun;
    float secondCounter;
    float frameCounter;
    public float health;
    public float maxHealth;
    public MainMenu mainMenuScript;
    public bool hasShotgun;
    public bool hasExplosiveBullets;
    public bool hasPiercingBullets;

    public HealthBarController healthBarScript;

    void Start()
    {
        health = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
        frameCounter = 1;
        hasShotgun = false;
        hasExplosiveBullets = false;
    }

    private void Awake()
    {
       // DontDestroyOnLoad(gameObject);
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
        secondCounter = 0;
        //play death anim
        //SceneManager.LoadScene("GameOverScreen");
       
       
        }

    private void FixedUpdate()
    {
        frameCounter++;
        secondCounter = frameCounter / 50;
        RB.MovePosition(RB.position + (moveDirection * moveSpeed * Time.fixedDeltaTime));

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health = health - 1;
        }

        if (other.CompareTag("Lava"))
        {
            health = health - 3;
        }
    }


}
