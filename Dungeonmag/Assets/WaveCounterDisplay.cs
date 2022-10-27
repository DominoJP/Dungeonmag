using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveCounterDisplay : MonoBehaviour
{

    public TMP_Text waveDisplay;
    public float waveNumber;

    // Start is called before the first frame update
    void Start()
    {
        waveNumber = 5;
        waveDisplay.text = " Health" + waveNumber.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        waveDisplay.text = " Health" + waveNumber.ToString();
    }
}
