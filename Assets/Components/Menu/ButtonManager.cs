using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public void ShowPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void HidePause()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1.0f;
    }
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1.0f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
