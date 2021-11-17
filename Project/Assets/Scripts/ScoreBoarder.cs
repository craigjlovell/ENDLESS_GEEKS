using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoarder : MonoBehaviour
{
    public ePlayer player;

    public Score score;
    [SerializeField] HighScoreSystem HSS;


    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if(ball != null)
        {
            ball.transform.position = new Vector3(0f, 0f, 0f);
            ball.rb.velocity = new Vector3(0, 0, 0);
            ball.InitialVelocity();
            if (player == ePlayer.PLAYER1)
            {
                score.scorePlayer1++;
                score.Player1scored = true;
                HSS.HighScore();
            }
            else if (player == ePlayer.PLAYER2)
            {
                score.scorePlayer2++;
                score.Player1scored = false;
            }
        }
    }
}
