using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters
{
    public int gold;
    public CharCell[] cells = new CharCell[4];

    public Characters()
    {
        for (int i = 0; i < cells.Length; i++)
        {
            cells[i] = new CharCell();
        }
    }

    public void AddItem(string code, int count)
    {
        int index = System.Array.FindIndex(cells, e => e.data.itemCode == code);
        if (index != -1)
        {
            cells[index].itemCount += count;
        }
        else
        {
            index = System.Array.FindIndex(cells, e => e.itemCount == 0);
            if (index != -1)
            {
                cells[index].data = CharMng.GetItem(code);
                cells[index].itemCount = count;
            }
        }
    }

    public void Remove(string code, int removeCount)
    {
        int index = System.Array.FindIndex(cells, e => e.data.itemCode == code);
        if (index != -1)
        {
            int itemCount = cells[index].itemCount;
            if (itemCount <= removeCount)
            {
                cells[index].Initialize();
            }
            else
            {
                cells[index].itemCount -= removeCount;
            }
        }
    }

    public void SwapItem(int dragIndex, int dropIndex)
    {
        CharCell cell = new CharCell();

        cell.SetCell(cells[dragIndex]);
        cells[dragIndex].SetCell(cells[dropIndex]);
        cells[dropIndex].SetCell(cell);
    }
}
