using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Loadscene()  //This code allows the user to move directly to the game after clicking the 'skip' button.
    {
        SceneManager.LoadScene(2);
    }

   
}
