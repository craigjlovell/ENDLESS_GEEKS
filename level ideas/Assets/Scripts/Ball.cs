using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    [SerializeField] GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
