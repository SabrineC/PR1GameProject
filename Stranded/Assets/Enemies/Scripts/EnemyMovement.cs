using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rbody;
    public Animator animator;
    public Transform Player;
    public float ChaseSpeed;
    public float Range;
    float CurrentSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector2 movement_vector = new Vector2(rbody.velocity.x, rbody.velocity.y);
        if (movement_vector != Vector2.zero)
        {
            animator.SetFloat("Horizontal", rbody.velocity.x);
            animator.SetFloat("Vertical", rbody.velocity.y);
            animator.SetFloat("CurrentSpeed", movement_vector.sqrMagnitude);
        }

        if (Vector3.Distance(transform.position, Player.position) <= Range)
        {
            CurrentSpeed = ChaseSpeed * Time.deltaTime; 
            transform.position = Vector3.MoveTowards(transform.position, Player.position, CurrentSpeed);
        }
    }
}
