using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerAttributes : MonoBehaviour
{
    public HealthBar health_bar;

    public Animator animator;

    // Health variables
    public int max_health = 100;
    public int current_health;

    void Start()
    {
        current_health = max_health;
        health_bar.SetMaxHealth(max_health);
    }

    void Update()
    {

    }

    // Removing player health from health bar when damaged
    
    public void Damaged(int damage)
    {
        current_health -= damage;
        health_bar.SetHealth(current_health);

        if (current_health <= 0 )
        {
            Death();
        }
    } 

    // Delayed time for death animation to play;
    IEnumerator DeathAnim(float time)
    {
        yield return new WaitForSeconds(time);
        Disappear();
    }

    void Death()
    {
        // Link death animation
        animator.SetTrigger("Died");
        // Start the delay time
        StartCoroutine(DeathAnim(1));
    }

    // Remove player from scene and apply the death screen
    void Disappear()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(3);
    }
}
