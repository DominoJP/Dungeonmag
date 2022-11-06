using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAimer : MonoBehaviour
{

    private Transform BulletTransform;
    private Camera Camera;
    public Transform BulletSpawn;
    public GameObject projectilePlaceholder;
    public GameObject player;
    PlayerController playerController;
    Transform scatterShot1;
    Transform scatterShot2;
    GameObject Aimer;

    // Start is called before the first frame update
    void Awake()
    {
        Camera = Camera.main;
        scatterShot1 = transform;
        scatterShot2 = transform;
    }

    // Update is called once per frame
    void Update()
    { 

        Vector3 AimerLocation = Camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 AimerRotation = AimerLocation - transform.position;

        float FireAngle = Mathf.Atan2(AimerRotation.y, AimerRotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, FireAngle);

      // scatterShot1.rotation = Quaternion.Euler(0, 0, FireAngle + 10);
      // scatterShot2.rotation = Quaternion.Euler(0, 0, FireAngle - 10);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePlaceholder, BulletSpawn.position, transform.rotation);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(projectilePlaceholder, BulletSpawn.position, transform.rotation);
        }

        if (Input.GetMouseButtonDown(1))
        {
            scatterShot1.rotation = Quaternion.Euler(0, 0, FireAngle + 10);
            Instantiate(projectilePlaceholder, BulletSpawn.position, scatterShot1.rotation);
        }

        if (Input.GetMouseButtonDown(1))
        {
            scatterShot2.rotation = Quaternion.Euler(0, 0, FireAngle - 10);
            Instantiate(projectilePlaceholder, BulletSpawn.position, scatterShot2.rotation);
        }

    }
}
