using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Vector3 startPos;
    private float repeatWidth;
    void Awake()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    void Update()
    {
        
        if(transform.position.x < startPos.x - repeatWidth) 
        {
            transform.position = startPos;
        
        }
    }
}
