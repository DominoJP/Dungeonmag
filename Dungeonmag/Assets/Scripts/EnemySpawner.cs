using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;
    float timeSinceWaveStart;
    float absoluteTime;
    float frameCounter;

    public WaveCounter waveCounterScript;
    

    // Start is called before the first frame update
    void Start()
    {
        waveCounterScript = GameObject.Find("Player").GetComponent<WaveCounter>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (waveCounterScript.waveNumber == 1)
        {
            SpawnEnemiesWave1();
        }

        if (waveCounterScript.waveNumber == 2)
        {
            SpawnEnemiesWave2();
        }

        if (waveCounterScript.waveNumber == 3)
        {
            SpawnEnemiesWave3();
        }

        if (waveCounterScript.waveNumber == 4)
        {
            SpawnEnemiesWave4();
        }

        if (waveCounterScript.waveNumber == 5)
        {
            SpawnEnemiesWave5();
        }

    }

    private void FixedUpdate()
    {
        frameCounter = frameCounter + 1;
    }

    private void SpawnEnemiesWave1()
    {
        if (frameCounter >= 150)
        {
            Instantiate(enemy, new Vector3(player.transform.position.x + 10, Random.Range(-5f, 5f), 0), Quaternion.Euler(0, 0, 0));
            frameCounter = 0f;
        }
    }


    private void SpawnEnemiesWave2()
    {
        if (frameCounter >= 100)
        {
            Instantiate(enemy, new Vector3(player.transform.position.x + 10, Random.Range(-5f, 5f), 0), Quaternion.Euler(0, 0, 0));
            frameCounter = 0f;
        }
    }


    private void SpawnEnemiesWave3()
    {
        if (frameCounter >= 75)
        {
            Instantiate(enemy, new Vector3(player.transform.position.x + 10, Random.Range(-5f, 5f), 0), Quaternion.Euler(0, 0, 0));
            frameCounter = 0f;
        }
    }


    private void SpawnEnemiesWave4()
    {
        if (frameCounter >= 50)
        {
            Instantiate(enemy, new Vector3(player.transform.position.x + 10, Random.Range(-5f, 5f), 0), Quaternion.Euler(0, 0, 0));
            frameCounter = 0f;
        }
    }


    private void SpawnEnemiesWave5()
    {
        if (frameCounter >= 45)
        {
            Instantiate(enemy, new Vector3(player.transform.position.x + 10, Random.Range(-5f, 5f), 0), Quaternion.Euler(0, 0, 0));
            frameCounter = 0f;
        }
    }




}
