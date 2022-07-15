using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingScreenUIManager : MonoBehaviour
{
    [SerializeField] private Button settingScreenQuitBtn;
    [SerializeField] private Button b;
    [SerializeField] private Button c;

   
    [SerializeField] private GameObject settingScreen;

    private void Awake()
    {
        settingScreenQuitBtn.onClick.AddListener(() =>
        {
            Destroy(settingScreen);
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
