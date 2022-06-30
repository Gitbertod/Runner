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
    //GameManager gameManagerScript;
    public bool gameOver = false;


    void Awake()
    {
       // gameManagerScript = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3 (0, -9.81f * gravityModifier) ;
        playerAnim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.anyKey && isGround && gameOver == false)
        {

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGround = false;
            playerAnim.SetTrigger("Jump_trig");
            Debug.Log(jumpForce);
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
            playerAnim.SetInteger("Death", 1);
            Debug.Log("aheo!");
        }
    }

    
}
