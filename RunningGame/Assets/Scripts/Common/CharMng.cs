using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharMng

{
    private static List<CharData> data = new List<CharData>();
    public static CharData GetItem(string itemCode) => data.Find(e => e.itemCode == itemCode);
    public static void AddItem(CharData item) => data.Add(item);
}
