using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform Collectables;
    public GameObject WinCanvas;
    public GameObject GameOverCanvas;
    public CharacterMove character;
    public Timer timer;

    public void Start()
    {
        timer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.GetTimeLeft() == 0) GameOver();
        else if (Collectables.childCount == 0) {
            Win();
            timer.StopTimer();
        }
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        character.StopMovement();
    }

    public void Win()
    {
        WinCanvas.SetActive(true);
        character.StopMovement();
    }
}
