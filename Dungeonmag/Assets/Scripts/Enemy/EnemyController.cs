using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Rigidbody2D enemyRB;
    public float health;
    public WaveCounter waveCounterScript;
    



    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        waveCounterScript = GameObject.Find("Player").GetComponent<WaveCounter>();
        enemyRB = gameObject.GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0f)
        {
            killEnemy();
        }

        void killEnemy()
        {
            Destroy(gameObject);
            waveCounterScript.enemiesKilled = waveCounterScript.enemiesKilled + 1f;
        }




    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Bullet"))
        {
            health = health - 1;
        }
    }

}
