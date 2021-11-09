using UnityEngine;

public enum ePlayer
{
    PLAYER1,
    PLAYER2
}

public class PaddleController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    public ePlayer player;
    public GameManager GM;
    public CameraControl CC;    
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

        Vector3 movement = new Vector3(inputX * GM.PaddleXSpeed * Time.deltaTime, inputY * GM.PaddleYSpeed * Time.deltaTime, 0);

        if (GM.is3d)
        {
            if (CC.camPos == 0)
            {
                if (player == ePlayer.PLAYER1)
                {
                    rb.MovePosition(-transform.position + movement);
                }
                else if (player == ePlayer.PLAYER2)
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
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Wall")
    //    {
    //        //rb.velocity = new Vector3(0, 0, 0);
    //    }
    //}

}
