using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //access Manager anywhere
    public static Manager instance;

    //list of 2 characters to select from
    public Character[] characters;

    public Character selected_character;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }

    private void StartGame()
    {
        if (characters.Length > 0 && selected_character == null)
        {
            selected_character = characters[0];
        }
    }

    public void SetCharacter(Character character)
    {
        selected_character = character;
    }
}
