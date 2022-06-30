using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacelPrefab;
    public float repeatRate = 2;
    public float time = 0;
    private PlayerController playerControllerScript;
    void Awake()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    
    void Update()
    {

        time += Time.deltaTime;
        
        if (time > repeatRate && !playerControllerScript.gameOver) 
        {
            time = 0;
            repeatRate = Random.Range(1, 5);
            ObstaclesSpawn();
        }  
    }

    private void ObstaclesSpawn() 
    {
        Instantiate(obstacelPrefab[Random.Range(0, 2)],transform.position,transform.rotation);
      
    }
    
}
