using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] bool X;
    [SerializeField] bool Y;
    [SerializeField] bool Z;
    public GameManager GM;

    [SerializeField] Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT");
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("HIT");
            if (X)
            {
                rb.velocity = new Vector3(-rb.velocity.x, rb.velocity.y, rb.velocity.z) * GM.acceleration;
            }
            else if (Y)
            {
                rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y, rb.velocity.z) * GM.acceleration;
            }
            else if (Z)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -rb.velocity.z) * GM.acceleration;
            }
        }
    }
}
