using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTribeman : MonoBehaviour
{
    public int damage;

    public TribemanAttributes tribeman_health;

    void OnCollisonEnter2D (Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemies") && Input.GetKeyDown(KeyCode.F))
        {
            tribeman_health.Damaged(damage);
        }

    }
}
