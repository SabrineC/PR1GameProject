using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 2f;

    public Rigidbody2D rb2D;

    public Animator animator;

    // Store vertical and horizontal inputs
    Vector2 movement;

    void Update()
    {
        // Getting input from wasd or arrow keys
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Linking animations to movement
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Making inputs into movement
        rb2D.MovePosition(rb2D.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
