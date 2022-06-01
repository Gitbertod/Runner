using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    float speed = 0.5f;
    Renderer rend;
    private PlayerController playerControllerScript;
    void Start()
    {
        rend = GetComponent<Renderer>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

   
    void Update()
    {
        if (playerControllerScript.gameOver == false) 
        {
            float offset = Time.time * -speed;
            rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        
        }
        
    }
}
