using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterSelectScreenUIManager : MonoBehaviour
{
    [SerializeField] private Button selectScreenQuitBtn;
    [SerializeField] private Button settingScreenLeftBtn;
    [SerializeField] private Button settingScreenRightBtn;
    [SerializeField] private Button settingScreenChooseBtn;

    [SerializeField] private GameObject selectScreen;
    [SerializeField] Animator anim;

    int index = 0;

    private void Awake()
    {
        
        selectScreenQuitBtn.onClick.AddListener(() =>
        {
            Destroy(selectScreen);
        });

        settingScreenLeftBtn.onClick.AddListener(() =>
        {
            if (--index < 0)
            {
                index = GameManager.myCharacters.Count - 1;
            }
            SelectCharacter();
        });

        settingScreenRightBtn.onClick.AddListener(() =>
        {
            if (++index >= GameManager.myCharacters.Count)
            {
                index = 0;
            }
            SelectCharacter();
        });

        settingScreenChooseBtn.onClick.AddListener(() =>
        {
            Destroy(selectScreen);
            EventManager.SendEvent("SelectCharacter", GameManager.myCharacters[index]);
            
        });
    }

    private void SelectCharacter()
    {
        anim.runtimeAnimatorController = GameManager.myCharacters[index].animatorController;
        GameManager.s_index = index;
    }

}
