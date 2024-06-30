using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public GameObject StartMenu, GameOverMenu,ScreenUI;

    // Start is called before the first frame update
    void Start()
    {
        StartMenu.SetActive(true);
        GameOverMenu.SetActive(false);
        ScreenUI.SetActive(false);
    }

    public void startGame()
    {
        StartMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
