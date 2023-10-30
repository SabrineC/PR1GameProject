using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathButtons : MonoBehaviour
{

    public void PlayAgain()
    {
        // When the retry button is clicked the scene returns to the map
        SceneManager.LoadScene(2);
    }
   public void ExitToMenu()
    {
        // When the exit button is clicked the scene returns to the main menu
        SceneManager.LoadScene(0);
    }
}
