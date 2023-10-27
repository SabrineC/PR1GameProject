using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttributes : MonoBehaviour
{
    public HealthBar health_bar;

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

    void Death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(3);
    }
}
