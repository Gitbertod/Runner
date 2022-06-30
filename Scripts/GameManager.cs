using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    bool animUi = false;
    [SerializeField,Range(0,1)]float time = 0;
    public Text scoreText;
    public GameObject pauseMenu;
    public RectTransform coinUI;
    private bool pause;

    private void Awake() 
    {
        coinUI = GameObject.Find("Coin_Image").GetComponent<RectTransform>();
        Time.timeScale = 1;
    } 

    void Update()
    {
        
        if (pause)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        if (animUi) 
        {
            animCoin();
        }
        else
        {

        }
       
    }

    public void PauseMenu()
    {
        pause = !pause;
    }
    public void RestartScence() => SceneManager.LoadScene(0);

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "" + score;
        Debug.Log(score);
        

    }
    public void animCoin() 
    {
        float animationCoin = Tweens.EaseOutElastic(0.5f,1f,time +=Time.deltaTime*0.25f);
        coinUI.localScale = new Vector2(animationCoin, animationCoin);
        animUi = !animUi;
    }
    

}
