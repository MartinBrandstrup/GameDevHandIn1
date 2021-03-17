using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int currentScore;
    public static int minesLeft;
    public Text scoreText;
    public static string scoreString = "Score = ";
    public static string mineString = ", Mines left = ";

    void Start()
    {
        currentScore = 0;
        minesLeft = MasterSettings.amountOfMines;
        scoreText = GameObject.Find("HighscorePause/Highscore/Highscore").GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = scoreString + currentScore + mineString + minesLeft;
    }
}