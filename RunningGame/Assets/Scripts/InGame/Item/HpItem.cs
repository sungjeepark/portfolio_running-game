using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : MonoBehaviour
{
    [SerializeField] private float healHp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            InGameManager.Instance.player.AddHp(healHp);

            gameObject.SetActive(false);
        }
    }
}
