using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingGlove : MonoBehaviour
{
    [SerializeField] private float punchSpeed = 2f;  // Speed of the punch
    [SerializeField] private float punchDistance = 3f;  // How far the punch moves
    [SerializeField] private float waitTime = 1f;  // Wait time before punching
    private Vector3 startPos;
    private bool isPunching = false;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (!isPunching)
        {
            // Wait before punching
            Invoke("StartPunching", waitTime);
        }
        else
        {
            // Move the punching glove in and out
            float move = Mathf.PingPong(Time.time * punchSpeed, punchDistance);
            transform.position = new Vector3(startPos.x, startPos.y, startPos.z + move);
        }
    }

    private void StartPunching()
    {
        isPunching = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().TakeDamage(10);
        }
    }
}
