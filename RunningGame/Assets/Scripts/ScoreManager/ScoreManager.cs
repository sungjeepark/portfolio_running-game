using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int nowScore;

    static ScoreManager instance;

    public static ScoreManager Instance
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

    public void AddScore(int score)
    {
        nowScore += score;
    }

    public int GetScore()
    {
        return nowScore;
    }
}
