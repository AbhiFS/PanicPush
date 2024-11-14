using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushAndRetractWall : MonoBehaviour
{
    public float pushSpeed = 2f;
    public float pushDistance = 2f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Using PingPong and then offsetting it by -pushDistance/2 allows movement left and right
        transform.position = startPos + Vector3.right * (Mathf.PingPong(Time.time * pushSpeed, pushDistance) - pushDistance / 2);
    }
}

