using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Set this checkpoint as the player's respawn position
            PlayerRespawn.lastCheckpointPosition = transform.position;
        }
    }
}