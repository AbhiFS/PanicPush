using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + new Vector3(Mathf.PingPong(Time.time * speed, distance), 0, 0);
    }
}