using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    
    //setting inital values of health bar to full
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    //calling slider to change when health is
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
