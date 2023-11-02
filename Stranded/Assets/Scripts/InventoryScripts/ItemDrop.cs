using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{ // Variables for the animals
    public GameObject item;
    private Transform AnimalPosition;  
   
 
    private void Start() // Starts off with having the item attached to the animal.
    {
        AnimalPosition = GetComponent<Transform>();
    }
 
    public void DropItem() // When the animal dies it drops the item it grabbed.
    {
        Instantiate(item, AnimalPosition.position, Quaternion.identity);
 
    }
 
}
 
