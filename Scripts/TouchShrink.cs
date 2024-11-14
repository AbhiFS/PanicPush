using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchShrink : MonoBehaviour
{
    // Shrink rate contorls how quickly the platform will shrink once touched
    [SerializeField] private float shrinkRate = 0.05f;

    // To track if the shrinking should start
    private bool isShrinking = false;



    // Update is called once per frame
    void Update()
    {
        // Shrink the platform if isShrinking is true


        if (isShrinking && transform.localScale.x > 0 && transform.localScale.z > 0)
        {
            // Reduce the scale of the platform on the x and z axes
            transform.localScale -= new Vector3(shrinkRate, 0, shrinkRate) * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Start shrinking if the player collides with the platform
        if (collision.gameObject.CompareTag("Player"))
        {
            isShrinking = true;
        }
    }
}
