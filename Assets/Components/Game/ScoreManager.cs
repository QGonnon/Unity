using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text scoreText;

    void Start()
    {

    }

    void Update()
    {
        scoreText.text = "Score : " + Mathf.Round(score);
    }


}
