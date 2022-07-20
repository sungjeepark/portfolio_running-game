using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetItem : MonoBehaviour
{
    [SerializeField] private float magnetTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            InGameManager.Instance.player.AddMagnetTime(magnetTime);

            gameObject.SetActive(false);
        }
    }
}
