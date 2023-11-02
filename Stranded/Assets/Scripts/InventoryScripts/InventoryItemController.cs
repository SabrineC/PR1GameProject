using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryItemController : MonoBehaviour
{
    public Item item;

    public void AddItem(Item newItem) // When the item is moved it is pushed into a new 'add item' which is them displayed in the inventory.
    {
        item = newItem;
    }



    public void UseItem() // This is the inventory code that allows the user to use the items.
    {
        switch (item.itemType)
        {
            case Item.ItemType.Coconut:
                player.Instance.IncreaseHealth(item.value);
                break;
            case Item.ItemType.Steak:
                player.Instance.IncreaseHealth(item.value);
                break;
            case Item.ItemType.Lamb:
                player.Instance.IncreaseHealth(item.value);
                break;
            case Item.ItemType.Chicken:
                player.Instance.IncreaseHealth(item.value);
                break;
        }
        Destroy(gameObject);
    }        
} 