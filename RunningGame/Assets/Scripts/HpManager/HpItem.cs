using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : MonoBehaviour
{
    [SerializeField] private int hp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            HpManager.Instance.AddHp(hp);

            gameObject.SetActive(false);
        }
    }
}
