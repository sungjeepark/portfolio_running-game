using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        CharMng.AddItem(new CharData("0001", "Mask Dude", "è��1", 1));
        CharMng.AddItem(new CharData("0002", "Pink Man", "è��2", 1));
        CharMng.AddItem(new CharData("0003", "Virtual Guy", "è��3", 1));
        CharMng.AddItem(new CharData("0004", "Ninja Frog", "è��4", 1));
    }
}
