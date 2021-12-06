using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables
    public bool PLAY;
    public bool is3d = false;
    public bool isLeft;

    public float PaddleXSpeed = 20f;
    public float PaddleYSpeed = 20f; 
    
    public float velocity;

    //ball vars
    public float acceleration;
    public float roundStartTime;
}
