using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveCounter : MonoBehaviour
{

    public float enemiesKilled;
    public float waveNumber;
    public WaveCounterDisplay waveCounterScript;

    // Start is called before the first frame update
    void Start()
    {
        waveCounterScript = GameObject.Find("Canvas").GetComponent<WaveCounterDisplay>();

        waveNumber = 1;
        enemiesKilled = 0;

    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
