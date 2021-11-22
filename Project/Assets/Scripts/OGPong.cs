using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OGPong : MonoBehaviour
{
    [SerializeField] Transform Player1;
    [SerializeField] Transform Player2;
    [SerializeField] Transform Ball;
    [SerializeField] GameObject PongPlayer1;
    [SerializeField] GameObject PongPlayer2;
    [SerializeField] GameObject PongBall;


    // Update is called once per frame
    void FixedUpdate()
    {
        PongPlayer1.transform.position = Camera.main.WorldToScreenPoint(Player1.transform.position);
        PongPlayer2.transform.position = Camera.main.WorldToScreenPoint(Player2.transform.position);
        PongBall.transform.position = Camera.main.WorldToScreenPoint(Ball.transform.position);
    }
}
