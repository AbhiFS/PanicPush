using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        // Set the player's health to the maximum at the start
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        // Reduce health and check if the player is out of health
        currentHealth -= damageAmount;
        Debug.Log("Player took damage. Current Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle the player's death (you can expand this as needed)
        Debug.Log("Player has died!");
        // Optionally, reload the scene or respawn the player
    }
}
