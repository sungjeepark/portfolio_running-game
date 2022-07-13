using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        CharMng.AddItem(new CharData("0001", "Mask Dude", "ц╗га1", 1));
        CharMng.AddItem(new CharData("0002", "Mask Dude", "ц╗га1", 1));
        CharMng.AddItem(new CharData("0003", "Mask Dude", "ц╗га1", 1));
        CharMng.AddItem(new CharData("0004", "Mask Dude", "ц╗га1", 1));
    }
}
