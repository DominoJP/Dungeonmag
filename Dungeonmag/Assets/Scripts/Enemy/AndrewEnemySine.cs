using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndrewEnemySine : MonoBehaviour
{

    float sinStartY;
    public float amplitude;
    public float frequency;

    // Start is called before the first frame update
    void Start()
    {
        sinStartY = transform.position.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = transform.position;

        float sin = Mathf.Sin(position.x * frequency) * amplitude;
        position.y = sinStartY + sin;

        transform.position = position;
    }
}
