using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    //attack variables
    public Transform attack_point;
    public float attack_range = 0.5f;
    public LayerMask enemy_layer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    void Attack()
    {
        //link animation to attack
        animator.SetTrigger("Attack");

        //if enemies are in range deals damage

    }
}

