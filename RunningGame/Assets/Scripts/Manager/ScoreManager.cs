using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int score;

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

        EventManager.AddEvent("InGame :: Init", (p) => 
        { 
            score = 0; 
        });
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public int GetScore()
    {
        return score;
    }
}
