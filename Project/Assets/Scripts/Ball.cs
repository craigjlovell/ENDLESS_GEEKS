using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] GameManager GM;
    [SerializeField] Score score;
    private AudioSource hitSource;

    [SerializeField] int RMin;
    [SerializeField] int RMax;
    [SerializeField] float ZInitSpeed;
    private float ZSpeed;
    float velocity;
    [SerializeField] float velocityBoost = 2;


    [SerializeField] GameObject ball;
    [SerializeField] GameObject spawn;


    [SerializeField]
    private float minVelocity = 10f;

    private Vector3 lastFrameVelocity;

    // Start is called before the first frame update
    void Start()
    {
        hitSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        InitialVelocity();
    }

    void StartGame()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    InitialVelocity();
        //}
        velocity = minVelocity;
    }

    void Update()
    {
        //StartGame();
        lastFrameVelocity = rb.velocity;
    }


    //plays sounds when the ball hits an object
    private void OnCollisionEnter(Collision collision)
    {
        //Joel's Audio Scripting//
        if (collision.gameObject.tag == "Paddle")
        {
            hitSource.Play();

        }

        Bounce(collision.contacts[0].normal, collision.contacts[0].point, collision.transform.position, collision.gameObject.tag);

        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            Debug.Log(contact.point);
        }
    }

    //perfectly reflects off any collider perfectly
    private void Bounce(Vector3 collisionNormal, Vector3 CollisionPoint, Vector3 CollisionTransform, string CollisionTag)
    {
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);
        Vector3 newDirection;
        
        Debug.Log("Out Direction: " + direction);

        if (CollisionTag == "Paddle")
        {
            newDirection = direction + (CollisionPoint - CollisionTransform);
            velocity = minVelocity;
        }
        else
        {
            newDirection = direction;
            velocity += velocityBoost;
        }
        rb.velocity = newDirection.normalized * velocity;
    }


    //when the game starts a new round the function determines its movement (call when needed)
    public void InitialVelocity()
    {
        StartCoroutine(RoundStart());
    }

    IEnumerator RoundStart()
    {
        ball.SetActive(false);
        spawn.SetActive(true);
        yield return new WaitForSeconds(GM.roundStartTime);
        ball.SetActive(true);
        spawn.SetActive(false);

        if (score.Player1scored) ZSpeed = -ZInitSpeed;
        else ZSpeed = ZInitSpeed;

        if (GM.is3d)
        {
            rb.AddForce(new Vector3(Random.Range(RMin, RMax), Random.Range(RMin, RMax), ZSpeed), ForceMode.Impulse);
            rb.constraints = RigidbodyConstraints.None;
        }
        else
        {
            rb.AddForce(new Vector3(0, Random.Range(RMin, RMax), ZSpeed), ForceMode.Impulse);
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }
    }

}
