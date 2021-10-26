using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoarder : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if(ball != null)
        {
            ball.transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}
