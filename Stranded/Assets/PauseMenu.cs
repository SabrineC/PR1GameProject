using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool PausedGame = false;

    public GameObject gameispausedMenu;


    void update (){
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
    void Resume()
    {
    gameispausedMenu.SetActive(false);
    Time.timeScale= 1f;
    PausedGame = false;

    }
    void Pause()
    {

    gameispausedMenu.SetActive(true);
    Time.timeScale= 0f;
    PausedGame = true;
    }
}