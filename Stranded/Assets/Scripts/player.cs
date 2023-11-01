using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    public PlayerAttributes playerHealth;
     
    public void IncreaseHealth(int value) //This code Increases The health of the player by the value.
    {
        playerHealth.IncreaseHealth(value);
        
    } 
       
}