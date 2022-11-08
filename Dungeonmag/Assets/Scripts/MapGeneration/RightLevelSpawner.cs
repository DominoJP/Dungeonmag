using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLevelSpawner : MonoBehaviour
{
    public Transform SpawnPosition;
    public bool HasSpawned = false;
    public GameObject LevelObject;
    public Collider2D RightCol;


    public void Awake()
    {
        RightCol = GetComponentInChildren<Collider2D>();
        LevelObject = GameObject.Find("RightLevelPrefab");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && HasSpawned == false)
        {
            Instantiate(LevelObject, SpawnPosition.transform.position, SpawnPosition.transform.rotation);
            Debug.Log("Is it?");
            HasSpawned = true;

        }
    }
}
