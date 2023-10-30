using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damage;
    private float cooldownTime = 1f; // Cooldown time before attack
    public PlayerAttributes playerHealth; // Getting player health
    private bool canDamage = true; // Checks if enemy can damage
    private bool playerInsideCollider = false; // Checks if player is inside collider

    public AudioSource ouch;

    // Checks if player is inside collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInsideCollider = true;
        }
    }

    // Checks if player is outside collider
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

    // Enemy deals damage after delay
    private IEnumerator DealDamageWithDelay()
    {
        if (canDamage)
        {
            canDamage = false;
            yield return new WaitForSeconds(cooldownTime);
            playerHealth.Damaged(damage);
            ouch.enabled = true;
            canDamage = true;
        }
    }
}

