using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySineAI : MonoBehaviour
{

    public Transform PointA;
    public Transform PointB;

    public float XSpeed;
    public float XAmplitude;
    public float XAmplitudeOffset;

    public float YSpeed;
    public float YAmplitude;
    public float YAmplitudeOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = PointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        var Yoffset = new Vector3(0, Mathf.Sin(Time.time * YSpeed) * YAmplitude + YAmplitudeOffset, 0);
        transform.position = Vector3.Lerp(PointA.position + Yoffset, PointB.position + Yoffset, Mathf.Sin(Time.time * XSpeed) * XAmplitude + XAmplitudeOffset);
    }
}
