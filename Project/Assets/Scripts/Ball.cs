using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager GM;
    public Score score;
    private AudioSource hitSource;

    public ParticleSystem spark;

    private int RMin = -1;
    private int RMax = 5;
    private float ZInitSpeed= 12.5f;
    private float ZSpeed;
    private float velocityBoost = 0.5f;
    private int amount = 0;


    public GameObject ball;
    public GameObject spawn;


    
    private float minVelocity = 20f;

    private Vector3 lastFrameVelocity;

    // Start is called before the first frame update
    void Start()
    {
        hitSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        InitialVelocity();
        GM.velocity = minVelocity;
        spark.Stop();
    }

    void Update()
    {
        lastFrameVelocity = rb.velocity;
    }


    //plays sounds when the ball hits an object
    private void OnCollisionEnter(Collision collision)
    {
        //Joel's Audio Scripting//
        if (collision.gameObject.tag == "Paddle")
        {
            hitSource.Play();
            spark.Play();
        }
        Bounce(collision.contacts[0].normal, collision.contacts[0].point, collision.transform.position, collision.gameObject.tag);
 
    }

    //perfectly reflects off any collider perfectly
    private void Bounce(Vector3 collisionNormal, Vector3 CollisionPoint, Vector3 CollisionTransform, string CollisionTag)
    {
        Vector3 direction;
        Vector3 newDirection;

        if (CollisionTag == "Paddle")
        {
            direction = Vector3.Reflect(lastFrameVelocity.normalized, Vector3.forward);
            newDirection = direction + (CollisionPoint - CollisionTransform);
            GM.velocity = minVelocity;
            
        }
        else
        {
            direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);
            newDirection = direction;
            GM.velocity += velocityBoost;
        }
        rb.velocity = newDirection.normalized * GM.velocity;
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
        GM.velocity = minVelocity;

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
