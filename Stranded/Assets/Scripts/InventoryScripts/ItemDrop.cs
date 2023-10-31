using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject item;
    private Transform animalPosition; 
   
 
    private void Start()
    {
        animalPosition = GetComponent<Transform>();
    }
 
    public void DropItem()
    {
        Instantiate(item, animalPosition.position, Quaternion.identity);
 
    }
 
}
 
