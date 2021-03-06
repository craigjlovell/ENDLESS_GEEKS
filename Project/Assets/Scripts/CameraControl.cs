using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControl : MonoBehaviour
{
    public int camPos;
    public float camSpeed;
    [SerializeField] float smooth;
    public Quaternion target;
    [SerializeField] Score score;
    private bool hit = false;
    public bool OGOn;
    public bool OGPermanent;

    [SerializeField] GameManager GM;
    [SerializeField] Canvas Pong2D;

    [SerializeField] CinemachineVirtualCamera CMtwoD;
    [SerializeField] CinemachineVirtualCamera CMzero;
    [SerializeField] CinemachineVirtualCamera CMone;
    [SerializeField] CinemachineVirtualCamera CMtwo;
    [SerializeField] CinemachineVirtualCamera CMthree;
    [SerializeField] CinemachineVirtualCamera CMfour;
    [SerializeField] CinemachineVirtualCamera CMnOne;
    [SerializeField] CinemachineVirtualCamera CMnTwo;
    [SerializeField] CinemachineVirtualCamera CMnThree;
    [SerializeField] CinemachineVirtualCamera CMnFour;

    private void Start()
    {
        if (PlayerPrefs.GetInt("OGMode", 0) == 0) { OGOn = true; ; OGPermanent = false; }
        if (PlayerPrefs.GetInt("OGMode", 0) == 1) { OGOn = false; OGPermanent = false; }
        if (PlayerPrefs.GetInt("OGMode", 0) == 2) { OGOn = true; OGPermanent = true; }

        CMtwoD.Priority = 1;
        CMnFour.Priority = 0;
        CMnThree.Priority = 0;
        CMnTwo.Priority = 0;
        CMnOne.Priority = 0;
        CMzero.Priority = 0;
        CMone.Priority = 0;
        CMtwo.Priority = 0;
        CMthree.Priority = 0;
        CMfour.Priority = 0;

        if (OGOn)
        {
            Pong2D.enabled = true;
        }
        else if (!OGOn)
        {
            Pong2D.enabled = false;
        }
    }

    void Update()
    {
        if (!OGPermanent)
        {
            camPos = score.scoreCam;
            if (camPos < -4)
            {
                camPos = -4;
            }
            else if (camPos == -4)
            {
                CMnFour.Priority = 1;
                CMnThree.Priority = 0;
            }
            else if (camPos == -3)
            {
                CMnFour.Priority = 0;
                CMnThree.Priority = 1;
                CMnTwo.Priority = 0;
            }
            else if (camPos == -2)
            {
                CMnThree.Priority = 0;
                CMnTwo.Priority = 1;
                CMnOne.Priority = 0;
            }
            else if (camPos == -1)
            {
                CMnTwo.Priority = 0;
                CMnOne.Priority = 1;
                CMzero.Priority = 0;
            }
            else if (camPos == 0 && hit)
            {
                CMnOne.Priority = 0;
                CMzero.Priority = 1;
                CMone.Priority = 0;
            }
            else if (camPos == 1)
            {
                CMzero.Priority = 0;
                CMone.Priority = 1;
                CMtwo.Priority = 0;
            }
            else if (camPos == 2)
            {
                CMone.Priority = 0;
                CMtwo.Priority = 1;
                CMthree.Priority = 0;
            }
            else if (camPos == 3)
            {
                CMtwo.Priority = 0;
                CMthree.Priority = 1;
                CMfour.Priority = 0;
            }
            else if (camPos == 4)
            {
                CMthree.Priority = 0;
                CMfour.Priority = 1;

            }
            else if (camPos > 4)
            {
                camPos = 4;
            }
            if (!hit)
            {
                if (score.scorePlayer1 != 0 || score.scorePlayer2 != 0)
                {
                    hit = true;
                    GM.is3d = true;
                    Debug.Log("zoom");
                        Pong2D.enabled = false;
                }
            }
            if (camPos <= -1)
            {
                GM.isLeft = true;
            }
            else if (camPos >= 1)
            {
                GM.isLeft = false;
            }
        }
    }
}

