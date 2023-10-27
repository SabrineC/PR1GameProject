using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TribemanAttributes : MonoBehaviour
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

    // Removing health from bar when damaged

    public void Damaged(int damage)
    {
        current_health -= damage;
        health_bar.SetHealth(current_health);
    }
}
