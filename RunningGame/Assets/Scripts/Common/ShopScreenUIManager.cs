using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopScreenUIManager : MonoBehaviour
{
    [SerializeField] private Button shopScreenQuitBtn;
    [SerializeField] private Button buyHeroButton1;
    [SerializeField] private GameObject buyHeroButton1_1;

    private int heroPrice1 = 1000000;
    TextMeshPro price1;
    [SerializeField] private GameObject shopScreen;

    private void Awake()
    {
        
        shopScreenQuitBtn.onClick.AddListener(() =>
        {
            Destroy(shopScreen);
        });

        buyHeroButton1.onClick.AddListener(() =>
        {
            if (DataManager.instance.Withdraw(heroPrice1))
            {
                
                
                GameManager.myCharacters.Add(CharMng.GetItem("0005"));

                Destroy(Resources.Load("Prefab/Screen/ShopScreen/CharacterBuyButton")); //instantiate하면 다시 생기니까 프리팹안에서 지워버려야 하는데 모르겠음
                Destroy(buyHeroButton1_1); // 오브젝트 내 버튼만 사라지길래 오브젝트 하나 만들어서 걍 없애버림
            }
            
        });

        
    }
}
