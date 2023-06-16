using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    public int maxHealth = 100;  // Maximum health of the object
    private int currentHealth;   // Current health of the object

    private void Start()
    {
        currentHealth = maxHealth;  // Initialize current health to maximum health
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;  // Decrease the current health by the damage amount

        if (currentHealth <= 0)
        {
            Destroy(gameObject);  // Destroy the object if its health reaches or falls below 0
        }
    }
}

