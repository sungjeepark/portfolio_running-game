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
    public AnimationClip itemClip;

    public CharData(string itemCode, string itemName, string itemDescript, int itemPrice)
    {
        this.itemCode = itemCode;
        this.itemName = itemName;
        this.itemDescript = itemDescript;
        this.itemPrice = itemPrice;
        itemClip = Resources.Load<AnimationClip>($"UI/Sprites/Item/{itemCode}"); // 경로 수정해야함

    }
}
