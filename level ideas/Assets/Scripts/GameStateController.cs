using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateController : MonoBehaviour
{
    //public Canvas canvas = null;

    public void MainMenu()
    {
        SceneManager.LoadScene("box");
    }

    public void Exit()
    {
        Application.Quit();
    }

    //public void GamePause()
    //{
    //    Time.timeScale = 0;
    //    canvas = GetComponentInParent<Canvas>();
    //    canvas.enabled = false;
    //    canvas = GameObject.FindGameObjectWithTag("").GetComponent<Canvas>();
    //    canvas.enabled = true;
    //}
    //public void GameResume()
    //{
    //    Time.timeScale = 1;
    //    canvas = GetComponentInParent<Canvas>();
    //    canvas.enabled = false;
    //    canvas = GameObject.FindGameObjectWithTag("").GetComponent<Canvas>();
    //    canvas.enabled = true;
    //}
}
