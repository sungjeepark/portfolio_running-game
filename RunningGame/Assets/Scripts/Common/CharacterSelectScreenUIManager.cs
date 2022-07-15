using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterSelectScreenUIManager : MonoBehaviour
{
    [SerializeField] private Button selectScreenQuitBtn;
    [SerializeField] private Button settingScreenLeftBtn;
    [SerializeField] private Button settingScreenRightBtn;

    [SerializeField] private GameObject selectScreen;
    


    private void Awake()
    {
        selectScreenQuitBtn.onClick.AddListener(() =>
        {
            Destroy(selectScreen);
        });

        /*settingScreenLeftBtn.onClick.AddListener(() =>
        {
            Destroy(settingScreen);
        });

        settingScreenRightBtn.onClick.AddListener(() =>
        {
            Destroy(shopScreen);
        });*/
    }
}
