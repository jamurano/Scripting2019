using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public static bool LevelIsComplete;
    public GameObject levelCompleteUI;

    public string mainMenu;
    public string gameScene;

    public void CompleteLevel()
    {
        LevelIsComplete = true;
        Time.timeScale = 0f;
        levelCompleteUI.SetActive(true);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Menu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
