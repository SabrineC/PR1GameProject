using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementspeed = 2f;

    public Rigidbody2D rb;

    public Animator animator;

    //store vertical and horizontal inputs
    Vector2 movement;

    void Update()
    {
        //getting Input from wasd or arrow keys
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //linking animations to movement
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        //making inputs into movement
        rb.MovePosition(rb.position + movement * movementspeed * Time.fixedDeltaTime);
    }
}
