using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCell
{
    public CharData data;
    public int itemCount;

    public CharCell()
    {
        Initialize();
    }

    public void Initialize()
    {
        data = new CharData("", "", "", 0);
        itemCount = 0;
    }

    public void SetCell(CharCell cell)
    {
        data = cell.data;
        itemCount = cell.itemCount;
    }
}
