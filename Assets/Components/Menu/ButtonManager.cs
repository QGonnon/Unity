using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
