using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{   
    public void PlayGame()     // This code allows the 'Play' button to move to the correct scene once clicked.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame()    // This code allows the user to leave the game once they click on the 'Exit' button.
    {
        Application.Quit();
    }
   
}
