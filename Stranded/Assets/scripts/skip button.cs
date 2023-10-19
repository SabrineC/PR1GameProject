using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Loadscene()
    {
        SceneManager.LoadScene("select");
    }

   
}
