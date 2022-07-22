using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingScreenUIManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputFieldNickName;

    [SerializeField] private Button settingScreenQuitBtn;
    [SerializeField] private Button changeNickNameBtn;
    [SerializeField] private Button resetHighScoreBtn;
    [SerializeField] private Button resetGameDataBtn;

   
    [SerializeField] private GameObject settingScreen;

    private void Awake()
    {
        settingScreenQuitBtn.onClick.AddListener(() =>
        {
            Destroy(settingScreen);
        });

        changeNickNameBtn.onClick.AddListener(() =>
        {
            if (inputFieldNickName.text != string.Empty)
            {
                DataManager.Instance.SetNickName(inputFieldNickName.text);
            }
        });

        resetHighScoreBtn.onClick.AddListener(() =>
        {

        });

        resetGameDataBtn.onClick.AddListener(() =>
        {

        });
    }
}
