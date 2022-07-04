using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float boostMultiplier;
    [SerializeField] private float jumpHeight;

    private Rigidbody2D rigid;
    private int jumpCount = 0;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }   

    void Update()
    {
        PlayerControl();

        this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            jumpCount = 0;
        }
    }

    private void PlayerControl()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 2)
            {
                rigid.velocity = new Vector2(0, jumpHeight);
                jumpCount += 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {

        }
    }
}
