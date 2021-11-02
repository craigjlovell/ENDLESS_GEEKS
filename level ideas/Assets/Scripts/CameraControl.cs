using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraControl : MonoBehaviour
{
    public GameObject camObj;
    public GameObject CamMTObj;
    private Camera cam;
    public int camPos;
    private Vector3 newPos;
    public float camSpeed;
    [SerializeField] float smooth;
    public Quaternion target;
    [SerializeField] Score score;
    private bool hit = false;

    GameManager game;

    private void Start()
    {
        cam = camObj.GetComponent<Camera>();
    }

    void Update()
    {
        camPos = score.scoreCam;
        if (camPos == -4)
        {
            target = Quaternion.Euler(0, 0, 0);
        }
        else if (camPos == -3)
        {
            target = Quaternion.Euler(0, -22.5f, 0);
        }
        else if (camPos == -2)
        {
            target = Quaternion.Euler(0, -45, 0);
        }
        else if (camPos == -1)
        {
            target = Quaternion.Euler(0, -67.5f, 0);            
        }
        else if (camPos == 0)
        {
            target = Quaternion.Euler(0, -90, 0);
        }
        else if (camPos == 1)
        {
            target = Quaternion.Euler(0, -112.5f, 0);
        }
        else if (camPos == 2)
        {
            target = Quaternion.Euler(0, -135, 0);
        }
        else if (camPos == 3)
        {
            target = Quaternion.Euler(0, -157.5f, 0);
        }
        else if (camPos == 4)
        {
            target = Quaternion.Euler(0, -180, 0);
        }
        if (!hit)
        {
            if (score.scorePlayer1 != 0 || score.scorePlayer2 != 0)
            {
                newPos = new Vector3(15, 0, 0);
                camObj.transform.position = Vector3.Lerp(camObj.transform.position, newPos, camSpeed);
                cam.fieldOfView = 90;
                game.is3d = true;
                hit = true;
                Debug.Log("zoom");
            }
        }
        CamMTObj.transform.rotation = Quaternion.Slerp(CamMTObj.transform.rotation, target, Time.deltaTime * smooth);
        Debug.Log("rotate");
    }
}

