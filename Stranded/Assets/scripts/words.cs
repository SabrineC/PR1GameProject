using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class words : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textspeed;
    private int index;


     void Start()
     {
        textComponent.text = string.Empty;
        startScript();
     }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];

            }

        }

    }
    void startScript()
    {
        index = 0;
        StartCoroutine(Typeline());
    }
    IEnumerator Typeline()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }


    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(Typeline());
        }
        else
        {
            gameObject.SetActive(false);

        }

    } 


    

}
        
