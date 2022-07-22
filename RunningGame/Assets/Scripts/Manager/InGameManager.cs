using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGameManager : MonoBehaviour
{
    public Player player;
    
    [SerializeField] Animator anim;
    static InGameManager instance;

    Animator me;

    public static InGameManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {

        me = GetComponent<Animator>();
        EventManager.AddEvent("SelectCharacter", OnSelectCharacter);

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

    private void OnSelectCharacter(params object[] p)
    {
        SetChar((CharData)p[0]);
    }

    public void SetChar(CharData data)
    {
        anim.runtimeAnimatorController = data.inGameAnimatorController;
        
    }
}
