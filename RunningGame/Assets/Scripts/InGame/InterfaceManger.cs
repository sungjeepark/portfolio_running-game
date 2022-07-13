using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfaceManger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Image bar;

    void Awake()
    {
        bar.fillAmount = 1f;
    }

    void LateUpdate()
    {
        scoreText.text = string.Format("{0:N0}", ScoreManager.Instance.GetScore());
        bar.fillAmount = HpManager.Instance.GetHpNormalized();
    }


}
