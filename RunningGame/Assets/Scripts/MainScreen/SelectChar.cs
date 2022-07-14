using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectChar : MonoBehaviour
{
    private List<Button> buttons = new List<Button>();


    public Character character;
    Animator anim;
    SpriteRenderer sR;
    public SelectChar[] chars;

    private int currentIndex;

    private void Start()
    {
        anim = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();
        if (DataManager.instance.currentCharacter == character) 
        {
            OnSelect();
        }
        else
        {
            OnDeselect();
        }
    }

    private void OnMouseUpAsButton()
    {
        DataManager.instance.currentCharacter = character;
        OnSelect();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != this)
            {
                chars[i].OnDeselect();
            }
        }
    }

    void OnSelect()
    {
        anim.SetBool("doublejump", true);
        sR.color = new Color(1f, 1f, 1f);
    }

    void OnDeselect()
    {
        anim.SetBool("doublejump", false);
        sR.color = new Color(.5f, .5f, .5f);
    }

    public void NextChar()
    {
        currentIndex++;
     //인벤토리의 아이템셀[currentIndex] 안에 캐릭터가 없으면 0으로 초기화

    }

    public void PreviewChar()
    {
        currentIndex--;
    }

    public void Refresh(CharCell cell)
    {
        
        if (cell.itemCount == 0)
        {
            
        }
    }
}
