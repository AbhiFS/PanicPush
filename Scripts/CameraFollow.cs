using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;        // Reference to the player's transform
    public Vector3 offset = new Vector3(0, 10, -10);  // Offset position of the camera

    void LateUpdate()
    {
        // Follow the player with an offset
        if (player != null)
        {
            transform.position = player.position + offset;
            transform.LookAt(player);
        }
    }
}
