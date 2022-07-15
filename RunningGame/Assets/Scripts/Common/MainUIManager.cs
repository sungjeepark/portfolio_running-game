using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainScreen;


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
            
            mainScreen =
            Instantiate((Resources.Load("Prefab/Screen/CharacterSelectScreen") as GameObject), this.transform.position, Quaternion.identity);
            mainScreen.transform.SetParent(this.transform);

            // selectScreen.transform.SetParent(mainScreen.transform, false);



        });
        //quitCharacterSelectbtn.onClick.AddListener(() =>
        //{
        //    this.loadPrefab = Resources.Load<GameObject>("Prefab/Screen/CharacterSelectScreen");
        //    loadPrefab.SetActive(false);
        //    Destroy(loadPrefab);
        //});



        







        ButtontoQuit.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
