using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthTest : MonoBehaviour
{
    public static healthTest Instance;

    public int Hnumber;
    public int Exp;

    public TextMeshProUGUI HText;
    public TextMeshProUGUI ExpText; 


    public void Awake()
    {
        Instance = this;
    }
     
    public void IncreaseHealth(int value)
    {
        Hnumber += value;
        HText.text = $"HP:{Hnumber}";
    } 
    public void IncreaseExp(int value)
    {
        Exp+= value;
        ExpText.text = $"HP:{Exp}";

    } 
}

