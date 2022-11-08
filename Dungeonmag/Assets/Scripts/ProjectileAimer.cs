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
    public int frameCounter;


    private GameObject[] enemies;
    public Transform closestEnemy;



    // Start is called before the first frame update
    void Awake()
    {
        Camera = Camera.main;
        scatterShot1 = transform;
        scatterShot2 = transform;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Start()
    {
        closestEnemy = null;
    }

    // Update is called once per frame
    void Update()
    {

        //closestEnemy = findClosestEnemy();
        ManageShooting();


    }


    private void FixedUpdate()
    {
        
        frameCounter=frameCounter+1;

        //Vector3 AimerLocation = Camera.ScreenToWorldPoint(new Vector3(1, 0, 0));

        //Vector3 AimerRotation = AimerLocation - transform.position;

        //FireAngle = Mathf.Atan2(AimerRotation.y, AimerRotation.x) * Mathf.Rad2Deg;

        //FireAngle = FireAngle + 7.2f;

        if (frameCounter >= 12)
        {
            FireAngle = 45;
        }

        FireAngle = 45;
        FireAngle = 135;
        FireAngle = 225;
        FireAngle = 315;

       

        transform.rotation = Quaternion.Euler(0f, 0f, FireAngle);
    }


    public void ShootShotgun()
    {
        bool shoot = true;

            if (shoot)
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


    public void ManageShooting()
    {
        if (playerController.hasShotgun == false && playerController.hasExplosiveBullets == false)
        {
            Instantiate(bullet, BulletSpawn.position, transform.rotation);
        }

        if (!playerController.hasShotgun && playerController.hasExplosiveBullets)
        {
            Instantiate(explosiveBullet, BulletSpawn.position, transform.rotation);
        }

        if (playerController.hasShotgun == true && playerController.hasExplosiveBullets)
        {
            ShootShotgunExplosive();
        }
        if (playerController.hasShotgun == true && playerController.hasExplosiveBullets == false)
        {
            ShootShotgun();
        }
    }


  /* public Transform findClosestEnemy()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        float minDistance = Mathf.Infinity;
        Transform enemyTransform = null;

        foreach (GameObject t in enemies) {
            float currentDistance;
            currentDistance = Vector3.Distance(enemyTransform.position, t.transform.position);

            if (currentDistance < minDistance)
            {
                minDistance = currentDistance;
                enemyTransform = t.transform;
            }
        }

        return enemyTransform;

    }*/


}