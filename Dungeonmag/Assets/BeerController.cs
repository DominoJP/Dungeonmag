using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerController : MonoBehaviour
{

    public PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            playerControllerScript.health = playerControllerScript.health + 10;
            Destroy(gameObject);
        }
    }

}
