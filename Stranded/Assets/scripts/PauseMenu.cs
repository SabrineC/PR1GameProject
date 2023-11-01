using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool pausedGame = false;
    public GameObject isPaused; 



    void Update ()  //This code checks if the user has pressed the 'Esc' Key on the keyboard, if the user has then the function 'pasuedGame' is played and if not then the game will resume.
    {
        if (Input.GetKeyDown(KeyCode.Escape))
       {
            if (pausedGame)
            {
                Resume(); 
            }
            else
            { 
                Pause();                            
            }   
       } 
         
    }
     public void Resume()  //This function checks to see if the game is paused and if it is not it will resume the game by unfreezing the time.
    {
        isPaused.SetActive(false);
        Time.timeScale = 1f;
        pausedGame = false;

    }
    public void Pause()  //This function freezes the time scale and this then stops all moving entities.
    {
        isPaused.SetActive(true);
        Time.timeScale = 0f;
        pausedGame = true;
    }

    public void LoadMenu()   //This function loads the correct scene.
    {
        SceneManager.LoadScene("Main Menu");
    }
    
}