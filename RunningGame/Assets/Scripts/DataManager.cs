using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    MaskDude, VirtualGuy, PinkMan, NinjaFrog
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;
}
