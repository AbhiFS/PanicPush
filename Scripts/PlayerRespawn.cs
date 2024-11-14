using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public static Vector3 lastCheckpointPosition;

    private void Start()
    {
        // Set the initial respawn point to the starting position
        lastCheckpointPosition = transform.position;
    }

    private void Update()
    {
        // Example check for falling: Respawn if y position is below -10
        if (transform.position.y < -10)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        // Teleport the player to the last checkpoint position
        transform.position = lastCheckpointPosition;
    }
}
