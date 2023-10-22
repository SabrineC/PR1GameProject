using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySpace : MonoBehaviour
{
    private Inventory inventory;
    public int i;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Makes the inventory space able to be occupied again
    private void Update()
    {
        if (transform.childCount <= 0) 
        {
            inventory.isFull[i] = false;
        }
    }

    // Removes item from inventory
    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

}
