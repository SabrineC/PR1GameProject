using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;

    void Pickup() //This code allows for the item to be moved from the scene to the Inventory.
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    void OnMouseDown() //This code calls the method 'Pickup' once the mouse has been clicked.
    {
        
        Pickup();
    }
}
