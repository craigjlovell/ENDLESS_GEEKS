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
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    // Increase max angular velocity or we won't see much spin.
    //    rb.maxAngularVelocity = 1000;
    //    StartCoroutine(ChangeRotation());
    //}
    //private IEnumerator ChangeRotation()
    //{
    //    while (true)
    //    {
    //        rb.AddTorque(new Vector3(10 * UnityEngine.Random.Range(0, 3f), UnityEngine.Random.Range(0, 3f), UnityEngine.Random.Range(0, 3f)), ForceMode.VelocityChange);
    //        yield return new WaitForSeconds(1);
    //    }
    //}
}
