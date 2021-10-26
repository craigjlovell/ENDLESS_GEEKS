using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject camObj;
    private Camera cam;
    public float score;

    private void Start()
    {
        cam = camObj.GetComponent<Camera>();
    }

    void Update()
    {
        if (score == -4)
        {
            camObj.transform.position = new Vector3(0, 0, -20);
        }
        else if (score == -3)
        {
            camObj.transform.position = new Vector3(10, 0, -19);
        }
        else if (score == -2)
        {
            camObj.transform.position = new Vector3(13, 0, -15);
        }
        else if (score == -1)
        {
            camObj.transform.position = new Vector3(17, 0, -8);
        }
        else if (score == 0)
        {
            cam.fieldOfView = 90;
            camObj.transform.position = new Vector3(15, 0, 0);
        }
        else if (score == 1)
        {
            camObj.transform.position = new Vector3(17, 0, 8);
        }
        else if (score == 2)
        {
            camObj.transform.position = new Vector3(13, 0, 15);
        }
        else if (score == 3)
        {
            camObj.transform.position = new Vector3(10, 0, 19);
        }
        else if (score == 4)
        {
            camObj.transform.position = new Vector3(0, 0, 20);
        }
    }
}

