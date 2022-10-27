using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveCounterDisplay : MonoBehaviour
{

    public TMP_Text waveDisplay;
    public float waveNumber;
    public float projectileDamage;

    // Start is called before the first frame update
    void Start()
    {
        waveNumber = 1;
        waveDisplay.text = "Wave: " + waveNumber.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        waveDisplay.text = "Wave: " + waveNumber.ToString();
    }





}
