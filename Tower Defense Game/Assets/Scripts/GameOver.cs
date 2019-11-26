using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI;

    public GameObject enemy;

    private void Start()
    {
        GameIsOver = false;
    }

    private void Update()
    {
        if (GameIsOver)
            return;

        if (gameObject)
        {
            EndGame();
        }
        
    }

    void EndGame()
    {
        GameIsOver = true;
        
        gameOverUI.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}