using UnityEngine;

public class Ground : MonoBehaviour
{
    float speed = 0.5f;
    Renderer rend;
    private PlayerController playerControllerScript;
    void Awake()
    {
        rend = GetComponent<Renderer>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

   
    void Update()
    {
        if (playerControllerScript.gameOver) return;

        float offset = Time.time * -speed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
