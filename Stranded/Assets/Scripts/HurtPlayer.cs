using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damage;
    private float cooldownTime = 1f; // Cooldown time before attack
    public PlayerAttributes playerHealth; // Getting player health
    private bool canDamage = true; // Checks if the enemy can damage
    private bool playerInsideCollider = false; // Checks if the player is inside the collider

    public AudioSource ouch;

    // Checks if the player is inside the collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInsideCollider = true;
        }
    }

    // Checks if the player is outside the collider
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInsideCollider = false;
        }
    }

    private void Update()
    {
        if (playerInsideCollider && canDamage)
        {
            StartCoroutine(DealDamageWithDelay());
        }
    }

    // Enemy deals damage after a delay
    private IEnumerator DealDamageWithDelay()
    {
        if (canDamage)
        {
            canDamage = false;
            yield return new WaitForSeconds(cooldownTime);
            playerHealth.Damaged(damage);
            // Player makes a sound when hit
            ouch.enabled = true;
            canDamage = true;
        }
    }
}

