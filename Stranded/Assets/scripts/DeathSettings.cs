using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSettings : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
    }
   public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
