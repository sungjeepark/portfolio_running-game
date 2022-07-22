using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharData
{
    public string itemCode;
    public string itemName;
    public string itemDescript;
    public int itemPrice;
    public Sprite itemImage;
    public RuntimeAnimatorController animatorController;
    public RuntimeAnimatorController inGameAnimatorController;

    public CharData(string itemCode, string itemName, string itemDescript, int itemPrice)
    {
        this.itemCode = itemCode;
        this.itemName = itemName;
        this.itemDescript = itemDescript;
        this.itemPrice = itemPrice;
        animatorController = Resources.Load<RuntimeAnimatorController>($"CharacterAnimator/{itemCode}");
        inGameAnimatorController = Resources.Load<RuntimeAnimatorController>($"Anim/Character/Controller/{itemCode}");

    }
}
