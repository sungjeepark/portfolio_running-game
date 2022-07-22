using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    public Animator animator;
    RuntimeAnimatorController controller;

    public bool PlayerDie = false;
    public float itemMoveSpeed = 15f;

    [SerializeField] private GameObject canves;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float boostMultiplier;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float maxHp;
    [SerializeField] private float hpReductionSpeed;

    private Rigidbody2D rigid;
    private int jumpCount = 2;
    private bool isJump = false;
    private float hp;
    private float magnetTimeCurrent = 0f;

    private bool flagGameOverUIOpen = true;

    public float GetHpNormalized()
    {
        return hp / maxHp;
    }

    public void Damage(float damage)
    {
        hp -= damage;
    }

    public void AddHp(float healHp)
    {
        hp += healHp;
    }

    public void AddMagnetTime(float magnetTime)
    {
        magnetTimeCurrent += magnetTime;
    }

    public float GetMagnetTime()
    {
        return magnetTimeCurrent;
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
                else if (jumpCount == 1) // ��������
                {
                    animator.SetBool("jump", false);
                    animator.SetBool("doublejump", true);
                    rigid.AddForce(Vector3.up * (jumpHeight / 1.5f), ForceMode2D.Impulse);
                    isJump = false;
                    jumpCount--;
                }
            }
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0f;

        PlayerDie = true;

        GameObject gameOverScreen = Instantiate((Resources.Load("Prefab/Screen/GameOverScreen") as GameObject), Vector3.zero, Quaternion.identity);
        gameOverScreen.transform.SetParent(canves.transform, false);

        EventManager.SendEvent("GameOver :: DisplayLastScore", ScoreManager.Instance.GetScore());
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

        if (collision.gameObject.layer.Equals(LayerMask.NameToLayer("DeadZone")))
        {
            hp = 0;
        }
    }

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        hp = maxHp;
    }

    private void Start()
    {
        InGameManager.Instance.player = this;
    }

    void Update()
    {
        PlayerControl();

        this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
    }

    void LateUpdate()
    {
        if (hp <= 0 && flagGameOverUIOpen)
        {
            flagGameOverUIOpen = false;
            GameOver();
        }

        hp -= hpReductionSpeed * Time.deltaTime;
        hp = Mathf.Clamp(hp, 0f, maxHp);

        magnetTimeCurrent -= Time.deltaTime;
        magnetTimeCurrent = Mathf.Clamp(magnetTimeCurrent, 0f, float.MaxValue);
    }
}
