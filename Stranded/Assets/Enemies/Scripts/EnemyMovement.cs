using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
/*     public Animator anim;
    public Transform target;
    public Transform homePosition;
    public float speed;
    public float maxRange;
    public float minRange;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        target = FindObjectOfType<PlayerMovement>().transform;
    } 

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(target.position.transform.position) <= maxRange && Vector2.Distance(target.position, transform.position)>= minRange)
        {
            FollowPlayer();
        }
        else if(Vector2.Distance(target.position, transform.position) >= maxRange)
        {
            GoHome();
        }

    }

    public void FollowPlayer()
    {
        anim.SetBool("isMoving", true);
        anim.SetFloat("moveX", (target.position.x - transform.position.x));
        anim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    public void GoHome()
    {
        anim.SetFloat("moveX", (homePosition.position.x - transform.position.x));
        anim.SetFloat("moveY", (homePosition.position.y - transform.position.y));
        transform.position = Vector2.MoveTowards(transform.position, homePosition, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, homePosition.position) == 0)
        {
            anim.SetBool("isMoving", false);
        }
    } */
}


