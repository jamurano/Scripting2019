using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver;
    public GameObject gameOverUI;

    public string mainMenu;
    public string gameScene;
    
    public void EndGame()
    {
        GameIsOver = true;
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Menu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}