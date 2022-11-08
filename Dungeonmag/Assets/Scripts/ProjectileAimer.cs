using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAimer : MonoBehaviour
{

    private Transform BulletTransform;
    private Camera Camera;
    public Transform BulletSpawn;
    public GameObject bullet;
    public GameObject explosiveBullet;
    public GameObject player;
    PlayerController playerController;
    Transform scatterShot1;
    Transform scatterShot2;
    GameObject Aimer;
    public float FireAngle;

    // Start is called before the first frame update
    void Awake()
    {
        Camera = Camera.main;
        scatterShot1 = transform;
        scatterShot2 = transform;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 AimerLocation = Camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 AimerRotation = AimerLocation - transform.position;

        FireAngle = Mathf.Atan2(AimerRotation.y, AimerRotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, FireAngle);



        if (Input.GetMouseButtonDown(0) && playerController.hasShotgun == false && playerController.hasExplosiveBullets == false)
        {
            Instantiate(bullet, BulletSpawn.position, transform.rotation);
        }

        if(Input.GetMouseButtonDown(0) && !playerController.hasShotgun && playerController.hasExplosiveBullets)
        {
            Instantiate(explosiveBullet, BulletSpawn.position, transform.rotation);
        }

        if (playerController.hasShotgun == true && playerController.hasExplosiveBullets)
        {
            ShootShotgunExplosive();
        }
        else
        {
            ShootShotgun();
        }

    }

    public void ShootShotgun()
    {

            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(bullet, BulletSpawn.position, transform.rotation);
            }

            if (Input.GetMouseButtonDown(1))
            {
                scatterShot1.rotation = Quaternion.Euler(0, 0, FireAngle + 10);
                Instantiate(bullet, BulletSpawn.position, scatterShot1.rotation);
            }

            if (Input.GetMouseButtonDown(1))
            {
                scatterShot2.rotation = Quaternion.Euler(0, 0, FireAngle - 10);
                Instantiate(bullet, BulletSpawn.position, scatterShot2.rotation);
            }

    }


    public void ShootShotgunExplosive()
    {

            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(explosiveBullet, BulletSpawn.position, transform.rotation);
            }

            if (Input.GetMouseButtonDown(1))
            {
                scatterShot1.rotation = Quaternion.Euler(0, 0, FireAngle + 10);
                Instantiate(explosiveBullet, BulletSpawn.position, scatterShot1.rotation);
            }

            if (Input.GetMouseButtonDown(1))
            {
                scatterShot2.rotation = Quaternion.Euler(0, 0, FireAngle - 10);
                Instantiate(explosiveBullet, BulletSpawn.position, scatterShot2.rotation);
            }

    }


}