using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterViewer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI charNameText;
    [SerializeField] Animator anim;
    [SerializeField] Button button;
    

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
        charNameText.text = data.itemName;
    }

  
}
