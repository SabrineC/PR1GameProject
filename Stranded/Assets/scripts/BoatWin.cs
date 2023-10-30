using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatWin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // When the player reaches the boat the scene will change to the Win Scene
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(4);
        }
    }
}
