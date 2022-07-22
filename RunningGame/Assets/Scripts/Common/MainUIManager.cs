using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainScreen;

    [SerializeField] private TextMeshProUGUI nickNameText;
    [SerializeField] private TextMeshProUGUI coinText;

    [SerializeField] private Button characterSelectbtn;
    [SerializeField] private Button quitCharacterSelectbtn;
    [SerializeField] private Button gameStartbtn;
    [SerializeField] private Button shopbtn;
    [SerializeField] private Button mailbtn;
    [SerializeField] private Button settingbtn;
    [SerializeField] private Button ButtontoQuit;


    public void Init()
    {

    }
    private void Awake()
    {
        characterSelectbtn.onClick.AddListener(() =>
        {
            GameObject selectScreen = Instantiate((Resources.Load("Prefab/Screen/CharacterSelectScreen") as GameObject), Vector3.zero, Quaternion.identity);
            selectScreen.transform.SetParent(mainScreen.transform, false);
        });

        shopbtn.onClick.AddListener(() =>
        {
            GameObject shopScreen = Instantiate((Resources.Load("Prefab/Screen/ShopScreen") as GameObject), Vector3.zero, Quaternion.identity);
            shopScreen.transform.SetParent(mainScreen.transform, false);
        });

        settingbtn.onClick.AddListener(() =>
        {
            GameObject settingScreen = Instantiate((Resources.Load("Prefab/Screen/SettingScreen") as GameObject), Vector3.zero, Quaternion.identity);
            settingScreen.transform.SetParent(mainScreen.transform, false);
        });

        gameStartbtn.onClick.AddListener(() =>
        {
            SceneController.S_Controller.OpenScene("InGame");
        });


        ButtontoQuit.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
    private void Update()
    {
        nickNameText.text = DataManager.Instance.GetNickName();
        coinText.text = string.Format("{0:N0} G", DataManager.instance.GetCoin());
    }
}
