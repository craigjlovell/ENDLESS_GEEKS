using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
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
    }
}
