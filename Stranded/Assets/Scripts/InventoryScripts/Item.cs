using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")] //Code so I can program a programmable Item.

public class Item : ScriptableObject
{ //Different types for each variable
    public int Id; 
    public string itemName;
    public int value;
    public Sprite icon;
    public ItemType itemType;

    public enum ItemType //The names and different types of items available. 
    {
        Coconut,
        Chicken,
        Lamb,
        Steak,
       
    }
}

