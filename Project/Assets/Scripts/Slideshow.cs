using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slideshow : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] int slide;
    [SerializeField] string objectName;

    [SerializeField] GameObject object1;
    [SerializeField] GameObject object2;
    [SerializeField] GameObject object3;
=======
    int slide;
    public int numberOfSlides;
    public string objectName;
    
    //public GameObject object4;
    public GameObject object2;
    public GameObject object3;
    public GameObject object1;
>>>>>>> 2ad0c1c3969b835bdfd2fd7ac793599772d8cba4

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
<<<<<<< HEAD
=======
        if (slide == 3)
        {
            //object4.SetActive(true);
        }
        else
        {
            //object4.SetActive(false);
        }
>>>>>>> 2ad0c1c3969b835bdfd2fd7ac793599772d8cba4
    }
}
