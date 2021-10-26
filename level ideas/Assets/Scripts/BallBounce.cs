using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    //[SerializeField] bool X;
    //[SerializeField] bool Y;
    //[SerializeField] bool Z;
    public GameManager GM;
    //
    //private Vector3 initialVelocity;
    //
    //[SerializeField]
    //private float minVelocity = 10f;
    //
    //private Vector3 lastFrameVelocity;
    //
    //[SerializeField] Rigidbody rb;

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("HIT");
    //    if (other.gameObject.tag == "Ball")
    //    {            
    //        Debug.Log("HIT");
    //        if (X)
    //        {
    //            rb.velocity = new Vector3(-rb.velocity.x * Random.value, rb.velocity.y, rb.velocity.z) * GM.acceleration;
    //        }
    //        else if (Y)
    //        {
    //            rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y * Random.value, rb.velocity.z) * GM.acceleration;
    //        }
    //        else if (Z)
    //        {
    //            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y * Random.value, -rb.velocity.z) * GM.acceleration;
    //        }
    //    }
    //}
    [SerializeField]
    [Tooltip("Just for debugging, adds some velocity during OnEnable")]
    private Vector3 initialVelocity;

    [SerializeField]
    private float minVelocity = 10f;

    private Vector3 lastFrameVelocity;
    private Rigidbody rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;
    }

    private void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
}
