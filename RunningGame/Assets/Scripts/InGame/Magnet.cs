using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player") && !InGameManager.Instance.player.PlayerDie)
        {
            if (InGameManager.Instance.player.GetMagnetTime() != 0f)
            {
                Vector2 dir = InGameManager.Instance.player.transform.position - transform.position;

                Vector2 pos = transform.parent.position;
                pos += dir.normalized * InGameManager.Instance.player.itemMoveSpeed * Time.deltaTime;
                transform.parent.position = pos;

                //transform.Translate(dir.normalized * InGameManager.Instance.player.itemMoveSpeed * Time.deltaTime, Space.World);
            }
        }
    }
}
