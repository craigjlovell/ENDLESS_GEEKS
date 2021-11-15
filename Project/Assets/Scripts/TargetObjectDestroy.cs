using UnityEngine;

public class TargetObjectDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log("functions");
            other.gameObject.SetActive(false);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {

    }
}
