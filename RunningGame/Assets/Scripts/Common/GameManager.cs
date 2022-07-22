using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<CharData> myCharacters = new List<CharData>();
    public static int s_index;


    private void Awake()
    {
        CharMng.AddItem(new CharData("0001", "Mask Dude", "Hero1", 1));
        CharMng.AddItem(new CharData("0002", "Ninja Frog", "Hero2", 1));
        CharMng.AddItem(new CharData("0003", "Pink Man", "Hero3", 1));
        CharMng.AddItem(new CharData("0004", "Virtual Guy", "Hero4", 1));
        CharMng.AddItem(new CharData("0005", "Ugly Stone", "Hero5", 1));

        GameManager.myCharacters.Add(CharMng.GetItem("0001"));
        GameManager.myCharacters.Add(CharMng.GetItem("0002"));
        GameManager.myCharacters.Add(CharMng.GetItem("0003"));
        GameManager.myCharacters.Add(CharMng.GetItem("0004"));
    }

    
}
