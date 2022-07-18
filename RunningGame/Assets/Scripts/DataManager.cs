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

    public static DataManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Character currentCharacter;
}
