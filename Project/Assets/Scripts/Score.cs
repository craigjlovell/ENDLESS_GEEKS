using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    Canvas canvas = null;
    public int scorePlayer1;
    public int scorePlayer2;
    public int scoreCam;
    public int scoreDiv = 1;

    public bool Player1scored;

    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;

    private void Update()
    {
        score1.text = scorePlayer1.ToString();
        score2.text = scorePlayer2.ToString();

        scoreCam = (scorePlayer2 - scorePlayer1) / scoreDiv;

        if (scorePlayer1 == 10)
        {
            Time.timeScale = 0;
            canvas = null;
            canvas = GameObject.FindGameObjectWithTag("Game").GetComponent<Canvas>();
            canvas.enabled = false;
            canvas = GameObject.FindGameObjectWithTag("GameOver").GetComponent<Canvas>();
            canvas.enabled = true;
        }
        else if (scorePlayer2 == 10)
        {
            Time.timeScale = 0;
            canvas = null;
            canvas = GameObject.FindGameObjectWithTag("Game").GetComponent<Canvas>();
            canvas.enabled = false;
            canvas = GameObject.FindGameObjectWithTag("GameOver2").GetComponent<Canvas>();
            canvas.enabled = true;
        }

    }

}
