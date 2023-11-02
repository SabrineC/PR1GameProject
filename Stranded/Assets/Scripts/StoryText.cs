using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StoryText : MonoBehaviour
{
    // Variables for the code
    public TextMeshProUGUI TextComponent;
    public string[] Lines;
    public float TextSpeed;
    private int Index;


     void Start() // This code makes an empty area so that I can add the story script to it.
     {
        TextComponent.text = string.Empty;
        startScript();
     }

    private void Update()  // This Block checks when the user clicks on the scene and will move on to the next sentence.
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (TextComponent.text == Lines[Index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                TextComponent.text = Lines[Index];

            }

        }

    }
    void startScript() // This code starts the scene.
    {
        Index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine() // This code displays the sentences letter by letter.
    {
        foreach (char c in Lines[Index].ToCharArray())
        {
            TextComponent.text += c;
            yield return new WaitForSeconds(TextSpeed);
        }
    }

    void NextLine() // This block moves over to the next line of code so that it is continuous 
    {
        if (Index < Lines.Length - 1)
        {
            Index++;
            TextComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);

        }

    } 
}
        
