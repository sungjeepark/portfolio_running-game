using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    public Animator animator;
    RuntimeAnimatorController controller;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float boostMultiplier;
    [SerializeField] private float jumpHeight;

    private Rigidbody2D rigid;
    private int jumpCount = 2;
    private bool isJump = false;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
       
    }   

    void Update()
    {
        PlayerControl();
        
        this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
    }

    

    private void PlayerControl()
    {
       

        if (jumpCount > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!isJump)
                {
                    isJump = true;
                    rigid.AddForce(Vector3.up * jumpHeight, ForceMode2D.Impulse);
                    animator.SetBool("jump", true);
                    jumpCount--;

                }
                else if (jumpCount == 1) // 더블점프
                {
                    animator.SetBool("jump", false);
                    animator.SetBool("doublejump", true);
                    rigid.AddForce(Vector3.up * (jumpHeight / 1.5f), ForceMode2D.Impulse);
                    isJump = false;
                    jumpCount--;
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer.Equals(LayerMask.NameToLayer("Ground")))
        {
            isJump = false;
            animator.SetBool("jump", false);
            animator.SetBool("doublejump", false);
            jumpCount = 2;
        }
    }
}
