using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTribewoman2 : MonoBehaviour
{
    public Animator animator;
    public int damage;
    public EntityAttributes entityAttributes;

    private bool isAttacking = false;
    private bool inCollider = false;

    // Player input causes character to attack
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
            isAttacking = true;
        }

        // If enemy is in range and attack input is pressed deals damage
        if(inCollider && isAttacking)
        {
            entityAttributes.Damaged(damage);
            isAttacking = false;
        }
    }
    void Attack()
    {
        // Link animation to attack
        animator.SetTrigger("Attack");
    }


    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.CompareTag("Tribewoman2"))
        {
            inCollider = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Tribewoman2"))
        {
            inCollider = false;
        }
    }
}

