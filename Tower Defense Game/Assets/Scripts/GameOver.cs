using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
//    public static bool GameIsOver = false;
//    public GameObject gameOverUI;
//    public GameObject castle;
//
//    private void OnTriggerEnter(Collider other)
//    {
//        castle = other.gameObject;
//        Destroy(gameObject);
//    }
//
//    private void Update()
//    {
//        if (OnTriggerEnter(Collider castle))
//        {
//            if (GameIsOver)
//            {
//                EndGame();
//            }
//        }
//    }
//
//    void EndGame()
//    {
//        gameOverUI.SetActive(true);
//        Time.timeScale = 0f;
//        GameIsOver = true;
//    }
//
//    public void LoadMenu()
//    {
//        Time.timeScale = 1f;
//        SceneManager.LoadScene("Menu");
//    }
//
//    public void QuitGame()
//    {
//        Debug.Log("Quitting Game...");
//        Application.Quit();
//    }
}