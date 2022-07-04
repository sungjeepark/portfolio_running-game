using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointItem : MonoBehaviour
{
    [SerializeField] private int point;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            ScoreManager.Instance.AddScore(point);

            gameObject.SetActive(false);
        }
    }
}
