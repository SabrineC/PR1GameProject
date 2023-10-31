using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    public static player Instance;

    public PlayerAttributes playerHealth;
    

    public void Awake()
    {
        player.Instance = this;
    }
     
    public void IncreaseHealth(int value)
    {
        playerHealth.IncreaseHealth(value);
        
    } 
       
}

