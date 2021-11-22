using UnityEngine;

public enum ePlayer
{
    PLAYER1,
    PLAYER2
}

public class PaddleController : MonoBehaviour
{
    public ePlayer player;
    public GameManager GM;
    public CameraControl CC;
    public Rigidbody rb;
    private float inputX;
    private float inputY;

    public float PaddleXSpeed;
    public float PaddleYSpeed;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {        
        if (player == ePlayer.PLAYER1)
        {
            inputX = Input.GetAxis("Horizontal")* PaddleXSpeed;
            inputY = Input.GetAxis("Vertical") * PaddleYSpeed;
            
        }
        else if (player == ePlayer.PLAYER2)
        {
            inputX = Input.GetAxis("Horizontal2") * PaddleXSpeed;
            inputY = Input.GetAxis("Vertical2") * PaddleYSpeed;
            
        }

        
    }

    private void FixedUpdate()
    {
        if (GM.is3d)
        {
            if (CC.camPos == 0)
            {
                if (player == ePlayer.PLAYER1)
                {
                    rb.velocity = new Vector3(-inputX, rb.velocity.y, 0f);
                }
                else if (player == ePlayer.PLAYER2)
                {
                    rb.velocity = new Vector3(inputX, rb.velocity.y, 0f);
                }
            }
            else
            {
                if (GM.isLeft)
                {
                    rb.velocity = new Vector3(inputX, rb.velocity.y, 0f);
                }
                else
                {
                    rb.velocity = new Vector3(-inputX, rb.velocity.y, 0f);
                }
            }
        }
        rb.velocity = new Vector3(rb.velocity.x, inputY, 0f);

        //if (player == ePlayer.PLAYER1)
        //{
        //    if (Input.GetAxisRaw("Horizontal") == 0) rb.velocity = new Vector3(0, rb.velocity.y, 0);
        //    if (Input.GetAxisRaw("Vertical") == 0) rb.velocity = new Vector3(rb.velocity.x, 0, 0);
        //}
        //if (player == ePlayer.PLAYER2)
        //{
        //    if (Input.GetAxisRaw("Horizontal2") == 0) rb.velocity = new Vector3(0, rb.velocity.y, 0);
        //    if (Input.GetAxisRaw("Vertical2") == 0) rb.velocity = new Vector3(rb.velocity.x, 0, 0);
        //}
    }
}
