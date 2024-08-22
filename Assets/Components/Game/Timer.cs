using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int seconds;
    public TMP_Text timerText;

    private int timeLeft;
    private bool endTimer = false;

    public void StartTimer()
    {
        StartCoroutine("TimerCountDown"); 
        endTimer = false;
    }

    public void StopTimer()
    {
        endTimer = true;
    }

    public int GetTimeLeft()
    {
        return timeLeft;
    }

    private IEnumerator TimerCountDown()
    {
        timeLeft = seconds;
        timerText.text = timeLeft.ToString();
        while (timeLeft > 0)
        {
            if(endTimer) break;
            yield return new WaitForSeconds(1);
            timeLeft--;
            timerText.text= timeLeft.ToString();
        }
    }
}
