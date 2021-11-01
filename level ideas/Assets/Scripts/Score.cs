using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scorePlayer1;
    public int scorePlayer2;
    public int scoreCam;
    public int scoreDiv;
    public GUIStyle style;

    void OnGUI()
    {
        float x = Screen.width / 2f;
        float y = 30f;
        float width = 300f;
        float height = 20f;
        string text = scorePlayer1 + " / " + scorePlayer2;

        GUI.Label(new Rect(x - (width / 2f), y, width, height), text, style);
    }

    private void Update()
    {
        scoreCam = (scorePlayer2 - scorePlayer1) / scoreDiv;
    }
}
