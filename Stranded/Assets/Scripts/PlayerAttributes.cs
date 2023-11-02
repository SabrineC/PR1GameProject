using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerAttributes : MonoBehaviour
{
    public HealthBar healthBar;

    public Animator animator;

    // Health variables
    public int maxHealth = 100;
    public int currentHealth;

    // Health is at max at start of the game
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void IncreaseHealth(int value) // This code increases the health of the player and then updating the healthbar.
    {
        currentHealth += value;
        healthBar.SetHealth(currentHealth);

    }

    // Removing player health from health bar when damaged
    
    public void Damaged(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0 )
        {
            Death();
        }
    } 

    // Delayed time for death animation to play;
    IEnumerator DeathAnimation(float time)
    {
        yield return new WaitForSeconds(time);
        Disappear();
    }

    void Death()
    {
        // Link death animation
        animator.SetTrigger("Died");
        // Start the delay time
        StartCoroutine(DeathAnimation(1));
    }

    // Remove player from scene and apply the death screen
    void Disappear()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(3);
    }
}
