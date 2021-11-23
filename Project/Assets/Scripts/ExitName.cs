using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitName : MonoBehaviour
{
    public Canvas UI;
    public Canvas Pong;
    public Canvas NamePanel;

    void Start()
    {
        Time.timeScale = 0;
        UI.enabled = false;
        Pong.enabled = false;
    }

    public void BeginGame()
    {
        NamePanel.enabled = false;
        Pong.enabled = true;
        UI.enabled = true;
        Time.timeScale = 1;
    }
}
