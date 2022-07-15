using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScreenUIManager : MonoBehaviour
{
    [SerializeField] private Button shopScreenQuitBtn;
    [SerializeField] private Button b;
    [SerializeField] private Button c;

    
    [SerializeField] private GameObject shopScreen;

    private void Awake()
    {
        shopScreenQuitBtn.onClick.AddListener(() =>
        {
            Destroy(shopScreen);
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
