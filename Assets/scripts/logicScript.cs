using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{

    
    public Text score;
    public int playerScore;
    public GameObject StartMenu, GameOverMenu, ScreenUI, logUI;


    [ContextMenu("Increase Score")]

    void Start()
    {
        StartMenu.SetActive(true);
        GameOverMenu.SetActive(false);
        ScreenUI.SetActive(false);
        logUI.SetActive(false);
    }

    //UI ekranýndaki text alanýna skor ekleme
    public void addScore(int scoreTAdd)
    {
        playerScore = playerScore + scoreTAdd;
        score.text = playerScore.ToString();
    }

    public void startGame()
    {
        StartMenu.SetActive(false);
        ScreenUI.SetActive(true);
      
    }

    //scene manager ile restart
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void exitButton()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        GameOverMenu.SetActive(true);
    }

}
