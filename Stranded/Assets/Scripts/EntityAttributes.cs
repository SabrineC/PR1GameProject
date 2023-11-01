using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAttributes : MonoBehaviour
{
    public HealthBar healthBar;
    public Animator animator;

    // Health variables
    public int maxHealth = 100;
    public int currentHealth;
    public ItemDrop getItem;  //This variable is for the food that the animales drop once killed.

    // Health is at max at start of the game
    void Start() 
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Removing player health from health bar when damaged
    
    public void Damaged(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0 )
        {
            if (getItem != null) //This code checks if it is not empty then it will get the item(food) and then drop it. Once droped the animale will die.
            {
                getItem.DropItem();
            } 
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

    // Remove entity from scene
    void Disappear()
    {
        Destroy(gameObject);
    }
}
