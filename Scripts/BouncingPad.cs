using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPad : MonoBehaviour
{
    public float bounceForce = 10f;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
