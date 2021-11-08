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
    public Rigidbody rb;
    private float inputX;
    private float inputY;

    private float speed;


    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        speed = 10f;
        if (player == ePlayer.PLAYER1)
        {
            inputX = Input.GetAxisRaw("Horizontal") * GM.PaddleXSpeed;
            inputY = Input.GetAxisRaw("Vertical") * GM.PaddleYSpeed;
        }
        else if (player == ePlayer.PLAYER2)
        {
            inputX = Input.GetAxisRaw("Horizontal2") * GM.PaddleXSpeed;
            inputY = Input.GetAxisRaw("Vertical2") * GM.PaddleYSpeed;
        }

        if (GM.is3d)
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
        rb.velocity = new Vector3(rb.velocity.x, inputY, 0f);

    }
    private void FixedUpdate()
    {

    }

}
