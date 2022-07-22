using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScreenUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lastScore;

    [SerializeField] private Button gameOverScreenExitBtn;

    private void Awake()
    {
        EventManager.AddEvent("GameOver :: DisplayLastScore", (p) =>
        {
            lastScore.text = string.Format("{0:N0} Á¡", p);
            DataManager.Instance.Deposit((int)p[0]);
        });

        gameOverScreenExitBtn.onClick.AddListener(() =>
        {
            EventManager.SendEvent("InGame :: Init");
            SceneController.S_Controller.OpenScene("Main");

            Time.timeScale = 1.0f;
        });
    }
}
