using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slideshow : MonoBehaviour
{
    int slide;
    public int numberOfSlides;
    public string objectName;
    
    //public GameObject object4;
    public GameObject object2;
    public GameObject object3;
    public GameObject object1;

    private void Start()
    {
        slide = PlayerPrefs.GetInt(objectName, 0);
    }

    void Next()
    {
        if (slide == numberOfSlides - 1)
        {
            slide = 0;
        }
        else
        {
            slide++;
        }
        PlayerPrefs.SetInt(objectName, slide);
    }

    void Previous()
    {
        if (slide == 0)
        {
            slide = numberOfSlides - 1;
        }
        else
        {
            slide++;
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
        if (slide == 3)
        {
            //object4.SetActive(true);
        }
        else
        {
            //object4.SetActive(false);
        }
    }
}
