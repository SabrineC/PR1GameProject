using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
  public AudioSource footsteps;

    void Update()
    {
        // When the player moves the sound will be played
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footsteps.enabled = true;
        }
        else
        {
            footsteps.enabled = false;
        }
    }
}
