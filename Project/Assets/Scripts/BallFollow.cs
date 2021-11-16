using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollow : MonoBehaviour
{
    [SerializeField] GameObject BFollowerTop;
    [SerializeField] GameObject BFollowerBottom;
    [SerializeField] GameObject BFollowerFar;
    [SerializeField] GameObject BFollowerClose;
    [SerializeField] GameObject Ball;
    private void FixedUpdate()
    {
        BFollowerTop.transform.position = new Vector3(Ball.transform.position.x, BFollowerTop.transform.position.y, Ball.transform.position.z);
        BFollowerBottom.transform.position = new Vector3(Ball.transform.position.x, BFollowerBottom.transform.position.y, Ball.transform.position.z);
        BFollowerFar.transform.position = new Vector3(BFollowerFar.transform.position.x, Ball.transform.position.y, Ball.transform.position.z);
        BFollowerClose.transform.position = new Vector3(BFollowerClose.transform.position.x, Ball.transform.position.y, Ball.transform.position.z);
    }
}
