using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damageAmount = 50;  // Amount of damage the projectile deals

    private void OnTriggerEnter(Collider other)
    {
        DamageReceiver damageReceiver = other.GetComponent<DamageReceiver>();

        if (damageReceiver != null)
        {
            //damageReceiver.TakeDamage(damageAmount);  // Call the TakeDamage() method on the damaged object
            Destroy(gameObject);  // Destroy the projectile after hitting the object
        }
    }
}
