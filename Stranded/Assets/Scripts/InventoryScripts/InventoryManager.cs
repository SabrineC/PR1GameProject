using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour


{ //variables for the items so I can drag the InventorItemController to the Player.
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent; 
    public GameObject InventoryItem;
    public InventoryItemController[] InventoryItems;
     

    private void Awake() 
    {
        Instance = this;

    }

    public void Add(Item item) //This code adds tge item.
    {
        Items.Add(item);
    }

    public void ListItems() //This code destroy the image of the item once used.
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in Items) //This code grabes the images and names of each item and puts it in the correct place.
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }   
        SetInventoryItems();
    }   


    public void SetInventoryItems() //This code gets the items and adds them to the Inventory.
    {
        InventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>(); 

        for (int i = 0; i <Items.Count; i++)
        {
            InventoryItems[i].AddItem(Items[i]);
        }

    }
}
