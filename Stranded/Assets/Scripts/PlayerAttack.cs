using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    public int damage;
    public EntityAttributes entity_attributes;

    // If enemies are in range deals damage
    private void OnCollisionEnter2D(Collision2D col) 
    {
        if(col.gameObject.tag == "Enemies")
        {
            entity_attributes.Damaged(damage);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }

    void Attack()
    {
        // Link animation to attack
        animator.SetTrigger("Attack");
    }
}

