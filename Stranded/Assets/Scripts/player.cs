using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class player : MonoBehaviour // If player is changed to Player the game will game.
{
    public static player Instance;

    public PlayerAttributes playerHealth;

    public void Awake()
    {
        player.Instance = this;
    }
     
     
    public void IncreaseHealth(int value) //This code Increases The health of the player by the value.
    {
        playerHealth.IncreaseHealth(value);
        
    } 
       
}