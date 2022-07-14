using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
    private GameObject loadPrefab;


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
            // this.loadPrefab = Resources.Load<GameObject>("Prefab/Screen/CharacterSelectScreen");
            GameObject A = Instantiate(Resources.Load<GameObject>("Prefab/Screen/CharacterSelectScreen")) as GameObject;
            //A.transform.SetParent(MainScreen.transform, false); 
            Instantiate(this.loadPrefab);
            loadPrefab.SetActive(true); // 낼 물어볼것
        });
        /*quitCharacterSelectbtn.onClick.AddListener(() =>
        {
            this.loadPrefab = Resources.Load<GameObject>("Prefab/Screen/CharacterSelectScreen");
            loadPrefab.SetActive(false);
        });*/











        ButtontoQuit.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
