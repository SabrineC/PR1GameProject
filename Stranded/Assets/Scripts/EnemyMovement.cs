using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Variables
    public Animator animator;
    public Transform target; // Follows the target (player)
    private Vector3 homePosition; // Starting position of the enemy
    public float speed; // Enemy movement speed
    public float maxRange; // Maximum range that the enemy can follow the player
    private bool isGoingHome = false; // Check to determine whether the enemy should go back to home position
    public float stoppingThreshold = 0.1f; // Thresehold that the enemy stops moving (for the home position)
    public float attackRange = 0.5f; // Range that the enemy stops to attack

    // Start is called before the first frame update
    void Start()
    {
        // Initialise variables
        animator = GetComponent<Animator>();
        target = FindObjectOfType<PlayerMovement>().transform; 
        homePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculates the distance to the target
        float distanceToTarget = Vector3.Distance(target.position, transform.position);
        
        // If the player is within the maximum range, follow the player
        if (distanceToTarget <= maxRange)
        {
            isGoingHome = false; 
            FollowPlayer(distanceToTarget); 
        }
        // If the player is not within maximum range, go back to the home position
        else if (distanceToTarget > maxRange)
        {
            isGoingHome = true;
            GoHome(); 
        }
    }

    // Follows the player
    public void FollowPlayer(float distanceToTarget)
    {
        Vector3 moveDirection = (target.position - transform.position).normalized;

        // If the distance to the player is greater than the attack range, continue following the player
        if (distanceToTarget > attackRange)
        {
            if (Mathf.Abs(moveDirection.x) > 0.1f)
            {
                moveDirection = new Vector3(Mathf.Sign(moveDirection.x), 0, 0);
            }
            else
            {
                moveDirection = new Vector3(0, Mathf.Sign(moveDirection.y), 0);
            }
            animator.SetFloat("Horizontal", moveDirection.x);
            animator.SetFloat("Vertical", moveDirection.y);
            transform.position = Vector3.MoveTowards(transform.position, transform.position + moveDirection, speed * Time.deltaTime);
        }
        else // If the player is within the attack range, stop moving
        {
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
        }
    }

    // Goes back to the home position
    public void GoHome()
    {
        if (!isGoingHome) return;

        Vector3 moveDirection = (homePosition - transform.position);

        // If the move direction magnitude is greater than the stopping threshold, continue moving towards the home position
        if (moveDirection.magnitude > stoppingThreshold)
        {
            moveDirection = moveDirection.normalized;

            // Set the move direction based on the home position
            if (Mathf.Abs(moveDirection.x) > Mathf.Abs(moveDirection.y))
            {
                moveDirection = new Vector3(Mathf.Sign(moveDirection.x), 0, 0);
            }
            else
            {
                moveDirection = new Vector3(0, Mathf.Sign(moveDirection.y), 0);
            }

            animator.SetFloat("Horizontal", moveDirection.x);
            animator.SetFloat("Vertical", moveDirection.y);

            transform.position = Vector3.MoveTowards(transform.position, homePosition, speed * Time.deltaTime);
        }
        else // If the enemy reaches the home position, stop moving
        {
            isGoingHome = false;
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
        }
    }
}
