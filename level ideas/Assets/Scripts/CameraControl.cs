using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject camObj;
    private Camera cam;
    public float score;
    private Vector3 newPos;
    private bool scored;
    public float camSpeed;

    private void Start()
    {
        cam = camObj.GetComponent<Camera>();
    }

    void Update()
    {
        if (score == -4)
        {
            newPos = new Vector3(0, 0, -20);
        }
        else if (score == -3)
        {
            newPos = new Vector3(10, 0, -19);
        }
        else if (score == -2)
        {
            newPos = new Vector3(13, 0, -15);
        }
        else if (score == -1)
        {
            newPos = new Vector3(17, 0, -8);
        }
        else if (score == 0)
        {
            cam.fieldOfView = 90;
            newPos = new Vector3(15, 0, 0);
        }
        else if (score == 1)
        {
            newPos = new Vector3(17, 0, 8);
        }
        else if (score == 2)
        {
            newPos = new Vector3(13, 0, 15);
        }
        else if (score == 3)
        {
            newPos = new Vector3(10, 0, 19);
        }
        else if (score == 4)
        {
            newPos = new Vector3(0, 0, 20);
        }

        if (scored)
        {
            camObj.transform.position = Vector3.Lerp(camObj.transform.position, newPos, camSpeed);
            camObj.transform.position = Vector3.Lerp(camObj.transform.position, newPos, camSpeed);
        }
    }
}

