using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerController playerControllerScript;
    
    void Awake() => playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    
    void Update()
    {
        if(playerControllerScript.gameOver == false) 
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= -25 || transform.position.y <-1) Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destroyer") 
        {
            Destroy(gameObject);        
        }
    }
}
