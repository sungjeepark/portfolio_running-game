using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Image bar;
    [SerializeField] private Button quitBtn;

    private void Awake()
    {
        bar.fillAmount = 1f;

        quitBtn.onClick.AddListener(() =>
        {
            SceneController.S_Controller.OpenScene("Main");
        });
    }

    void LateUpdate()
    {
        scoreText.text = string.Format("{0:N0}", ScoreManager.Instance.GetScore());
        bar.fillAmount = InGameManager.Instance.player.GetHpNormalized();
    }

    void Start() 
    {
        LoadSceneAdditive(); 
    }

    void LoadSceneAdditive() { SceneManager.LoadScene("Stage1", LoadSceneMode.Additive); }
}
