using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public GameManager GM;
    //Joel's Audio Scripting//00
    private AudioSource hitSource;

    [SerializeField]
    [Tooltip("Just for debugging, adds some velocity during OnEnable")]
    private Vector3 initialVelocity;

    [SerializeField]
    private float minVelocity = 10f;

    private Vector3 lastFrameVelocity;
    [SerializeField] Rigidbody rb;

    //Joel's Audio Scripting//
    private void Start ()
    {
        hitSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;
    }

    private void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision){
        //Joel's Audio Scripting//
        if (collision.gameObject.tag == "Paddle")
        {
            hitSource.Play();

        }

        Bounce(collision.contacts[0].normal);
        //hitSource.Play();

    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
}
