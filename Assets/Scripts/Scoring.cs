using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;
    public int Score;
    public int HighScore;
    public int ScoreChange = 4;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScore = PlayerPrefs.GetInt("HighScore");
        }
        Score = 0;
        InvokeRepeating("ScoreUpdate", 0.5f, 0.25f);
    }

    void Update()
    {
        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
        ScoreText.text = "Score: " + Score;
        HighScoreText.text = "Highscore: " + HighScore;
    }
    void ScoreUpdate()
    {

        Score += ScoreChange;
    }
}
