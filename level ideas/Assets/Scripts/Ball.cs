using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    [SerializeField] GameManager GM;
    private AudioSource hitSource;


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

    private void OnCollisionEnter(Collision collision)
    {
        //Joel's Audio Scripting//
        if (collision.gameObject.tag == "Paddle")
        {
            hitSource.Play();

        }

        Bounce(collision.contacts[0].normal);

    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }

    public void InitialVelocity()
    {
        if (GM.is3d)
        {
            rb.AddForce(new Vector3(4, 0, 4), ForceMode.Impulse);
            rb.constraints = RigidbodyConstraints.None;
        }
        else
        {
            rb.AddForce(new Vector3(0, 0, 4), ForceMode.Impulse);
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }
    }
}
