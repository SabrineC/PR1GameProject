using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageChicken6 : MonoBehaviour
{
    public Animator animator;
    public int damage;
    public EntityAttributes entity_attributes;

    private bool isAttacking = false;
    private bool inCollider = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
            isAttacking = true;
        }

        // If animal is in range and attack input is pressed deals damage
        if(inCollider && isAttacking)
        {
            entity_attributes.Damaged(damage);
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
        if (col.gameObject.CompareTag("Chicken6"))
        {
            inCollider = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Chicken6"))
        {
            inCollider = false;
        }
    }
}
