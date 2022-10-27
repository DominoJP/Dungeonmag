using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Rigidbody2D enemyRB;
    float health;
    float moveSpeed;
    public WaveCounter waveCounterScript;
    public float localEnemiesKilled;




    // Start is called before the first frame update
    void Start()
    {
        
        waveCounterScript = GameObject.Find("Canvas").GetComponent<WaveCounter>();
        localEnemiesKilled = waveCounterScript.enemiesKilled;


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
            localEnemiesKilled = localEnemiesKilled + 1f;
        }


        
    }
}
