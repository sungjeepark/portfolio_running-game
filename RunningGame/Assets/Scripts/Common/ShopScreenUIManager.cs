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

                Destroy(Resources.Load("Prefab/Screen/ShopScreen/CharacterBuyButton")); //instantiate�ϸ� �ٽ� ����ϱ� �����վȿ��� ���������� �ϴµ� �𸣰���
                Destroy(buyHeroButton1_1); // ������Ʈ �� ��ư�� ������淡 ������Ʈ �ϳ� ���� �� ���ֹ���
            }
            
        });

        
    }
}
