using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int currentScore = 0;
    Text scoreText;

    void Start()
    {
        currentScore = 0;
        scoreText = GameObject.Find("HighscorePause/Highscore/Highscore").GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Score = " + currentScore;
    }
}