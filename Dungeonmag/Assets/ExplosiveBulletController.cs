using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBulletController : MonoBehaviour
{
    public float BulletSpeed;
    public Rigidbody2D BulletRB;
    public PlayerController playerScript;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        BulletRB.velocity = transform.right * BulletSpeed;
        Destroy(gameObject, 3);


    }


    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Enemy"))
        {

            Instantiate(explosion, transform.position, transform.rotation);

            if (playerScript.hasPiercingBullets == false)
            {
                Destroy(gameObject); 
            }
            
        }

       

    }

}
