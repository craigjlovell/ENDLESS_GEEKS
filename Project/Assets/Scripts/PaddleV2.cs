using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum ePlayer2
{
    PLAYER1,
    PLAYER2
}

public class PaddleV2 : MonoBehaviour
{
    public Rigidbody rb;

    public ePlayer2 player;
    public GameManager GM;
    public CameraControl CC;

    private float inputX;
    private float inputY;

    public float PaddleXSpeed = 20f;
    public float PaddleYSpeed = 20f;

    public float maxUp;
    public float maxDown;
    public float maxLeft;
    public float maxRight;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (player == ePlayer2.PLAYER1)
        {
            inputX = Input.GetAxisRaw("Horizontal") * PaddleXSpeed;
            inputY = Input.GetAxisRaw("Vertical") * PaddleYSpeed;

        }
        else if (player == ePlayer2.PLAYER2)
        {
            inputX = Input.GetAxisRaw("Horizontal2") * PaddleXSpeed;
            inputY = Input.GetAxisRaw("Vertical2") * PaddleYSpeed;

        }
    }

    private void FixedUpdate()
    {

        Vector3 movement = new Vector3(inputX * PaddleXSpeed * Time.deltaTime, inputY * PaddleYSpeed * Time.deltaTime, 0);
        if (transform.position.y >= maxUp && movement.y > 0)
        {
            movement.y = 0;
        }
        else if (transform.position.y <= maxDown && movement.y < 0)
        {
            movement.y = 0;
        }
        else if (transform.position.x >= maxRight && movement.x > 0)
        {
            movement.x = 0;
        }
        else if (transform.position.x <= maxLeft && movement.x < 0)
        {
            movement.x = 0;
        }

        if (GM.is3d)
        {
            if (CC.camPos == 0)
            {
                if (player == ePlayer2.PLAYER1)
                {
                    rb.MovePosition(-transform.position + movement);
                }
                else if (player == ePlayer2.PLAYER2)
                {
                    rb.MovePosition(transform.position + movement);
                }
            }
            else
            {
                if (GM.isLeft)
                {
                    rb.MovePosition(transform.position + movement);
                }
                else
                {
                    rb.MovePosition(-transform.position + movement);
                }
            }
        }
        rb.MovePosition(transform.position + movement);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, maxLeft, maxRight), Mathf.Clamp(transform.position.y, maxDown, maxUp), transform.position.z);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Gizmos.DrawCube(Vector3.zero, new Vector3(7f, 7f, 7f));
    }

}
