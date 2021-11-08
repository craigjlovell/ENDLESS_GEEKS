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
    [SerializeField] Rigidbody rb;
    private float inputX;
    private float inputY;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        speed = 10f;
        //Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"),0); 
        //Vector3 m_Input2 = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxisRaw("Vertical2"), 0);
        if (player == ePlayer.PLAYER1)
        {
            inputX = Input.GetAxisRaw("Horizontal")* GM.PaddleXSpeed;
            inputY = Input.GetAxisRaw("Vertical") * GM.PaddleYSpeed;
            
        }
        else if (player == ePlayer.PLAYER2)
        {
            inputX = Input.GetAxisRaw("Horizontal2") * GM.PaddleXSpeed;
            inputY = Input.GetAxisRaw("Vertical2") * GM.PaddleYSpeed;
            
        }

        Vector3 tempVect = new Vector3(inputX, inputY, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        if (GM.is3d)
        {
            if (CC.camPos == 0)
            {
                if (player == ePlayer.PLAYER1)
                {
                    //rb.MovePosition(-transform.position + tempVect * speed);
                    rb.velocity = new Vector3(-inputX, rb.velocity.y, 0f);
                }
                else if (player == ePlayer.PLAYER2)
                {
                    //rb.MovePosition(transform.position + tempVect * speed);
                    rb.velocity = new Vector3(inputX, rb.velocity.y, 0f);
                }
            }
            else
            {
                if (GM.isLeft)
                {
                    //rb.MovePosition(transform.position + tempVect * speed);
                    rb.velocity = new Vector3(inputX, rb.velocity.y, 0f);                    
                }
                else
                {
                    //rb.MovePosition(-transform.position + tempVect *  speed);
                    rb.velocity = new Vector3(-inputX, rb.velocity.y, 0f);                    
                }
            }
        }
        rb.velocity = new Vector3(rb.velocity.x, inputY, 0f);
        //rb.MovePosition(transform.position + tempVect * speed);
    }
    private void FixedUpdate()
    {

    }

}
