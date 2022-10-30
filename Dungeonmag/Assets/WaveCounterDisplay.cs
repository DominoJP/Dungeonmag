using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveCounterDisplay : MonoBehaviour
{

    public TMP_Text waveDisplay;
    public float waveNumber;
    public float projectileDamage;
    public WaveCounter waveCounterScript;

    // Start is called before the first frame update
    void Start()
    {
        waveNumber = 1;
        waveDisplay.text = "Wave: " + waveNumber.ToString();
        waveCounterScript = GameObject.Find("Player").GetComponent<WaveCounter>();
    }
    
    // Update is called once per frame
    void Update()
    {

        if (waveCounterScript.enemiesKilled >= 5)
        {
            waveNumber = waveNumber + 1;
            waveCounterScript.enemiesKilled = 0;
        }

        waveDisplay.text = "Wave: " + waveNumber.ToString();


    }





}
