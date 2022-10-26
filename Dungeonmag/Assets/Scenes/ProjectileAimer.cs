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

    // Start is called before the first frame update
    void Awake()
    {
        Camera = Camera.main;
        //playerController = player.GetComponent<PlayerController>;
    }

    // Update is called once per frame
    void Update()
    { 

        Vector3 AimerLocation = Camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 AimerRotation = AimerLocation - transform.position;

        float FireAngle = Mathf.Atan2(AimerRotation.y, AimerRotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, FireAngle);


        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePlaceholder, BulletSpawn.position, transform.rotation);
        }


    }
}
