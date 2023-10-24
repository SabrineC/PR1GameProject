using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool PausedGame = false;

    public GameObject gameispausedMenu;



    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
       {
        if (PausedGame)
        {
            Resume(); 
        }
        else
        { 
            Pause();                            
        }
       } 
         
    }
     public void Resume()
    {
        gameispausedMenu.SetActive(false);
        Time.timeScale= 1f;
        PausedGame = false;

    }
    public void Pause()
    {
        gameispausedMenu.SetActive(true);
        Time.timeScale= 0f;
        PausedGame = true;
    }

    public void loadmenu()
    {
        SceneManager.LoadScene ("Main Menu");

    }
    
    

}