using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoarder : MonoBehaviour
{
    public ePlayer player;

    public Score score;
    public HighScoreSystem HSS;
    private AudioSource goalSoundSource;


    private void Start()
    {
        goalSoundSource = GetComponent<AudioSource>();

    }

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
                goalSoundSource.Play();
                score.Player1scored = true;
                HSS.HighScore();
            }
            else if (player == ePlayer.PLAYER2)
            {
                score.scorePlayer2++;
                goalSoundSource.Play();
                score.Player1scored = false;
            }
        }
    }
}
