using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
  public AudioSource attackSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            attackSound.enabled = true;
        }
        else
        {
            attackSound.enabled = false;
        }
    }
}