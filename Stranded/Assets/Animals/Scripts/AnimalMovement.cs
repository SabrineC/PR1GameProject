using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator; 

    private Rigidbody2D rb2d;
    private Vector2[] directions = { Vector2.up, Vector2.down, Vector2.left, Vector2.right }; // This is an array of possible movement directions (N,S,W,E)
    private Vector2 currentDirection; 
    private float timer;
    private float changeDirectionTime = 2f; // This is the duration for changing direction
    private float walkingTime;
    private bool isWalking = true;
    private float randomOffset;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>(); 
        ChooseNewDirection(); // Calling so that entity changes direction
        randomOffset = Random.Range(0f, 5f); // Creates random offset so that all entities do not move at same time
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalking)
        {
            MoveEntity(currentDirection); // Calling to move the entity in the direction
            UpdateAnimation(currentDirection); // Calling to update the animation based on the direction
            walkingTime += Time.deltaTime;

            // Checks to see if it's time to stop walking
            if (walkingTime >= changeDirectionTime + randomOffset)
            {
                isWalking = false;
                walkingTime = 0;
                rb2d.velocity = Vector2.zero;
                UpdateAnimation(Vector2.zero);
            }
        }
        else
        {
            walkingTime += Time.deltaTime;
            
            // Checks to see if it's time to start walking again, if so it will choose a new direction
            if (walkingTime >= changeDirectionTime)
            {
                isWalking = true;
                walkingTime = 0;
                ChooseNewDirection();
                randomOffset = Random.Range(0f, 5f);
            }
        }
    }

    // Moves the entity in a different direction
    void MoveEntity(Vector2 direction)
    {
        rb2d.velocity = direction * moveSpeed;
    }

    // Updates the animation based on the direction
    void UpdateAnimation(Vector2 direction)
    {
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.magnitude);
    }

    // Chooses a new direction randomly from the array of directions
    void ChooseNewDirection()
    {
        int randomIndex = Random.Range(0, directions.Length); 
        currentDirection = directions[randomIndex];
    }
}
