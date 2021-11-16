using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateController : MonoBehaviour
{
    public Canvas canvas = null;

    public void Game()
    {
        SceneManager.LoadScene("box");
    }
    public void Map1()
    {
        SceneManager.LoadScene("MountEruption");
    }
    public void Map2()
    {
        SceneManager.LoadScene("NeonCity");
    }
    public void Map3()
    {
        SceneManager.LoadScene("OceansDepth");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Customisation()
    {
        SceneManager.LoadScene("Customisation");
    }


    public void Exit()
    {
        Application.Quit();
    }

    public void GamePause()
    {
        Time.timeScale = 0;
        canvas = GetComponentInParent<Canvas>();
        canvas.enabled = false;
        canvas = GameObject.FindGameObjectWithTag("Pause").GetComponent<Canvas>();
        canvas.enabled = true;
    }
    public void GameResume()
    {
        Time.timeScale = 1;
        canvas = GetComponentInParent<Canvas>();
        canvas.enabled = false;
        canvas = GameObject.FindGameObjectWithTag("Game").GetComponent<Canvas>();
        canvas.enabled = true;
    }
}
