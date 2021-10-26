using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer
{
    PLAYER1,
    PLAYER2
}

public class PaddleController : MonoBehaviour
{
    public float speed = 5f;
    public ePlayer player;
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputSpeedX = 0f;
        float inputSpeedY = 0f;
        if(player == ePlayer.PLAYER1)
        {
            inputSpeedX = Input.GetAxisRaw("Horizontal");
            inputSpeedY = Input.GetAxisRaw("Vertical");
        }
        else if(player == ePlayer.PLAYER2)
        {
            inputSpeedX = Input.GetAxisRaw("Horizontal2");
            inputSpeedY = Input.GetAxisRaw("Vertical2");
        }
        transform.position += new Vector3(inputSpeedX * -GM.PaddleXSpeed * Time.deltaTime, 0f, 0f);
        transform.position += new Vector3(0f, inputSpeedY * GM.PaddleXSpeed * Time.deltaTime, 0f);
    }

    private void Move()
    {

    }
}
