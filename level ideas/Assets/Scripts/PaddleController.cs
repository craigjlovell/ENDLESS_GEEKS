using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public bool isPlayer1;
    public Rigidbody rb;

    private float movementY;
    private float movementX;

    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1)
        {
            movementY = Input.GetAxisRaw("Vertical");
            movementX = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            movementY = Input.GetAxisRaw("Vertical2");
            movementX = Input.GetAxisRaw("Horizontal2");
        }
        if (GM.PLAY)
        {
            Move();
        }

    }

    private void Move()
    {

        if (!GM.is3d)
        {
            rb.velocity = new Vector3(rb.velocity.x, movementY * GM.PaddleYSpeed);
        }
        else if (GM.isLeft)
        {
            rb.velocity = new Vector3(movementX * GM.PaddleXSpeed, movementY * GM.PaddleYSpeed);
        }
        else
        {
            rb.velocity = new Vector3(movementX * -GM.PaddleXSpeed, movementY * GM.PaddleYSpeed);
        }
    }
}
