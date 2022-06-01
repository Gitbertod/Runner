using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerController playerControllerScript;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    
    void Update()
    {
        if(playerControllerScript.gameOver == false) 
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
