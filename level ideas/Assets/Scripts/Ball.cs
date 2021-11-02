using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] GameManager GM;
    private AudioSource hitSource;

    [SerializeField] int RMin;
    [SerializeField] int RMax;
    [SerializeField] float ZInitSpeed;


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
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
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

        }

        Bounce(collision.contacts[0].normal);

    }

    //perfectly reflects off any collider perfectly
    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }


    //when the game starts a new round the function determines its movement (call when needed)
    public void InitialVelocity()
    {
        if (GM.is3d)
        {
            rb.AddForce(new Vector3(Random.Range(RMin, RMax), Random.Range(RMin, RMax), ZInitSpeed * (Random.Range(0, 2) * 2 - 1)), ForceMode.Impulse);
            rb.constraints = RigidbodyConstraints.None;
        }
        else
        {
            rb.AddForce(new Vector3(0, Random.Range(RMin, RMax), ZInitSpeed * (Random.Range(0, 2) * 2 - 1)), ForceMode.Impulse);
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }
    }
}
