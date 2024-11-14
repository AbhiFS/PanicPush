using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatform : MonoBehaviour
{
    public float shrinkSpeed = 1f;
    private Vector3 originalScale;

    void Start() { originalScale = transform.localScale; }
    void Update()
    {
        float scaleModifier = Mathf.PingPong(Time.time * shrinkSpeed, 1);
        transform.localScale = originalScale * scaleModifier;
    }
}

