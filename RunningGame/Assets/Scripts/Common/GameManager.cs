using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<CharData> myCharacters = new List<CharData>();


    private void Awake()
    {
        CharMng.AddItem(new CharData("0001", "Mask Dude", "ц╗га1", 1));
        CharMng.AddItem(new CharData("0002", "Pink Man", "ц╗га2", 1));
        CharMng.AddItem(new CharData("0003", "Virtual Guy", "ц╗га3", 1));
        CharMng.AddItem(new CharData("0004", "Ninja Frog", "ц╗га4", 1));

        GameManager.myCharacters.Add(CharMng.GetItem("0001"));
        GameManager.myCharacters.Add(CharMng.GetItem("0002"));
        GameManager.myCharacters.Add(CharMng.GetItem("0003"));
        GameManager.myCharacters.Add(CharMng.GetItem("0004"));
    }

    
}
