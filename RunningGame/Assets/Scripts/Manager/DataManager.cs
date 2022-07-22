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

    private string nickName = "User001";
    private int coin = 100000000;

    public void SetNickName(string value) 
    {
        nickName = value;
    }

    public string GetNickName()
    {
        return nickName;
    }

    public void Deposit(int value)
    {
        coin += value;
    }

    public bool Withdraw(int value)
    {
        if (coin - value >= 0)
        {
            coin -= value;
            return true;
        } 
        else
        {
            return false;
        }
    }

    public int GetCoin()
    {
        return coin;
    }
}
