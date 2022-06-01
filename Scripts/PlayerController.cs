using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 250;
    public bool isGround = true;
    public float gravityModifier = 5;
    private Rigidbody rb;
    private Animator playerAnim;
    public bool gameOver = false; 
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround && gameOver== false) 
        {
            
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGround = false;
            playerAnim.SetTrigger("Jump_trig");
            Debug.Log("key!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Ground")) 
       {
            isGround = true;
       } 

       if (collision.gameObject.CompareTag("Obstacle")) 
       {
            gameOver = true;
            playerAnim.SetInteger("Death",1);
            Debug.Log("aheo!");
       }
    }
}
