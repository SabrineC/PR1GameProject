/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Item : ScriptableObject{

    [Header("Only gameplay")]
    public TileBase tile;
    public ItemType type;
    public ActionType ActionTypes;
    public Vector2Int range = new Vector2Int(5,4);

    [Header("only UI")]
    public bool stackable = true;

    [Header("Both")] 
    public Sprite image;
}

    public enum ItemType{
        BuildingBlock, 
        Tool
    }                   
    public enum ActionType{
        Dig,
        Mine
    }


  

*/