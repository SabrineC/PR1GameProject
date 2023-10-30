using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButtons : MonoBehaviour
{
   public void ExitToMenu()
    {
        // When the exit button is selected the scene returns to the main menu
        SceneManager.LoadScene(0);
    }
}
