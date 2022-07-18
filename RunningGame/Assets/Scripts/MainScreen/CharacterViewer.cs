using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterViewer : MonoBehaviour
{
    Animator me;
    private void Awake()
    {
        me = GetComponent<Animator>();
        EventManager.AddEvent("SelectCharacter", OnSelectCharacter);
    }

    private void OnSelectCharacter(params object[] p)
    {
        SetChar((CharData)p[0]);
    }

    public void SetChar(CharData data)
    {
        me.runtimeAnimatorController = data.animatorController;
    }
}
