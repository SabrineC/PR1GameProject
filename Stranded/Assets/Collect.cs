
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            // Checking if inventory is full
            for (int i = 0; i < inventory.spaces.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    // If inventory isn't full pick up item
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.spaces[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}