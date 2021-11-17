using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_2 : MonoBehaviour
{
    public int camPos;
    public float camSpeed;
    [SerializeField] float smooth;
    public Quaternion target;
    [SerializeField] Score score;
    private bool hit = false;
    [SerializeField] bool camVersionTwo;

    [SerializeField] GameManager GM;

    [SerializeField] CinemachineVirtualCamera CMTwoD;
    [SerializeField] CinemachineVirtualCamera CMZero;
    [SerializeField] CinemachineVirtualCamera CMOne;
    [SerializeField] CinemachineVirtualCamera CMTwo;
    [SerializeField] CinemachineVirtualCamera CMNOne;
    [SerializeField] CinemachineVirtualCamera CMNTwo;

    [SerializeField] CinemachineVirtualCamera CMAZero;
    [SerializeField] CinemachineVirtualCamera CMAOne;
    [SerializeField] CinemachineVirtualCamera CMATwo;
    [SerializeField] CinemachineVirtualCamera CMAThree;
    [SerializeField] CinemachineVirtualCamera CMANOne;
    [SerializeField] CinemachineVirtualCamera CMANTwo;
    [SerializeField] CinemachineVirtualCamera CMANThree;

    private void Start()
    {
        CMTwoD.Priority = 1;
        CMNTwo.Priority = 0;
        CMNOne.Priority = 0;
        CMZero.Priority = 0;
        CMOne.Priority = 0;
        CMTwo.Priority = 0;
    }

    void Update()
    {
        camPos = score.scoreCam;
        if (camVersionTwo)
        {
            if (camPos < -2)
            {
                camPos = -2;
            }
            else if (camPos == -2)
            {
                CMNTwo.Priority = 1;
                CMNOne.Priority = 0;
            }
            else if (camPos == -1)
            {
                CMNTwo.Priority = 0;
                CMNOne.Priority = 1;
                CMZero.Priority = 0;
            }
            else if (camPos == 0 && hit)
            {
                CMNOne.Priority = 0;
                CMZero.Priority = 1;
                CMOne.Priority = 0;
            }
            else if (camPos == 1)
            {
                CMZero.Priority = 0;
                CMOne.Priority = 1;
                CMTwo.Priority = 0;
            }
            else if (camPos == 2)
            {
                CMOne.Priority = 0;
                CMTwo.Priority = 1;
            }
            else if (camPos > 2)
            {
                camPos = 2;
            }
        }
        else
        {
            if (camPos < -3)
            {
                camPos = -3;
            }
            else if (camPos == -3)
            {
                CMANThree.Priority = 1;
                CMANTwo.Priority = 0;
            }
            else if (camPos == -2)
            {
                CMANThree.Priority = 0;
                CMANTwo.Priority = 1;
                CMANOne.Priority = 0;
            }
            else if (camPos == -1)
            {
                CMANTwo.Priority = 0;
                CMANOne.Priority = 1;
                CMAZero.Priority = 0;
            }
            else if (camPos == 0 && hit)
            {
                CMANOne.Priority = 0;
                CMAZero.Priority = 1;
                CMAOne.Priority = 0;
            }
            else if (camPos == 1)
            {
                CMAZero.Priority = 0;
                CMAOne.Priority = 1;
                CMATwo.Priority = 0;
            }
            else if (camPos == 2)
            {
                CMAOne.Priority = 0;
                CMATwo.Priority = 1;
                CMAThree.Priority = 0;
            }
            else if (camPos == 3)
            {
                CMATwo.Priority = 0;
                CMAThree.Priority = 1;
            }
            else if (camPos > 3)
            {
                camPos = 3;
            }
        }
        if (!hit)
        {
            if (score.scorePlayer1 != 0 || score.scorePlayer2 != 0)
            {
                hit = true;
                GM.is3d = true;
                Debug.Log("zoom");
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

