using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpManager : MonoBehaviour
{
    [SerializeField] private float maxHp;
    [SerializeField] private float hpReductionSpeed;

    private static float nowHp;

    static HpManager instance;

    public static HpManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        nowHp = maxHp;

        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void LateUpdate()
    {
        nowHp -= hpReductionSpeed * Time.deltaTime;
        nowHp = Mathf.Clamp(nowHp, 0f, maxHp);
    }

    public void AddHp(int hp)
    {
        nowHp += hp;
    }

    public void Damage(int damage)
    {
        nowHp -= damage;
    }

    public float GetHpNormalized()
    {
        return nowHp / maxHp;
    }
}
