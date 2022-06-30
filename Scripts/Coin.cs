using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameManager gameManagerScript;
    void Awake()
    {
        gameManagerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    
    void Update()
    {
        transform.Rotate(Vector3.right * 2f);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            gameManagerScript.animCoin();
            gameManagerScript.AddScore(1);
            
            Destroy(gameObject);

        }


    }

}
