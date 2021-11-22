using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slideshow : MonoBehaviour
{
    private int slide;
    public string objectName;

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    private void Start()
    {
        slide = PlayerPrefs.GetInt(objectName, 0);
    }

    public void Next()
    {
        if (slide == 2)
        {
            slide = 0;
        }
        else
        {
            slide++;
        }
        PlayerPrefs.SetInt(objectName, slide);
    }

    public void Previous()
    {
        if (slide == 0)
        {
            slide = 2;
        }
        else
        {
            slide--;
        }
        PlayerPrefs.SetInt(objectName, slide);
    }

    private void Update()
    {
        if (slide == 0)
        {
            object1.SetActive(true);
        }
        else
        {
            object1.SetActive(false);
        }

        if (slide == 1)
        {
            object2.SetActive(true);
        }
        else
        {
            object2.SetActive(false);
        }

        if (slide == 2)
        {
            object3.SetActive(true);
        }
        else
        {
            object3.SetActive(false);
        }
    }
}
