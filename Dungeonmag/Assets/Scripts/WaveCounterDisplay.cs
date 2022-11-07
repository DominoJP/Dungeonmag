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
    public float enemiesUntilNextWave;

    // Start is called before the first frame update
    void Start()
    {
        waveDisplay.text = "Wave: " + waveNumber.ToString();
        waveCounterScript = GameObject.Find("Player").GetComponent<WaveCounter>();
    }
    
    // Update is called once per frame
    void Update()
    {
        waveNumber = waveCounterScript.waveNumber;
        waveDisplay.text = "Wave: " + waveNumber.ToString();


    }





}
