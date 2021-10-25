using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody rb;

    private float movementY;
    private float movementX;

    public bool is3d = false;
    public bool isLeft = false;

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
        Move();
    }

    private void Move()
    {

        if (!is3d)
        {
            rb.velocity = new Vector3(rb.velocity.x, movementY * speed);
        }
        else if (isLeft)
        {
            rb.velocity = new Vector3(movementX * speed, movementY * speed);
        }
        else
        {
            rb.velocity = new Vector3(movementX * -speed, movementY * speed);
        }
    }
}
