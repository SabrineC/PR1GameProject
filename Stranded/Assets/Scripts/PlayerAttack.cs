using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    // Attack variables
    public Transform attack_point;
    public float attack_range = 0.5f;
    public LayerMask enemy_layer;

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

        // If enemies are in range deals damage

    }
}

