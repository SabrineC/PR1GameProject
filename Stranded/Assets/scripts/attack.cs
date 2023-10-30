using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
  public AudioSource attack;

    void Update()
    {
        // When the player attacks the sound plays
        if(Input.GetKey(KeyCode.F))
        {
            attack.enabled = true;
        }
        else
        {
            attack.enabled = false;
        }
    }
}