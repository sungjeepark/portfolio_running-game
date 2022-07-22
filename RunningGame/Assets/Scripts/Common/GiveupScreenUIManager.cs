using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveupScreenUIManager : MonoBehaviour
{
    [SerializeField] private Button giveupScreenContinueBtn;
    [SerializeField] private Button giveupScreenExitBtn;

    [SerializeField] private GameObject giveupScreen;

    private void Awake()
    {
        giveupScreenContinueBtn.onClick.AddListener(() => 
        {
            Destroy(giveupScreen);

            Time.timeScale = 1.0f;
        });

        giveupScreenExitBtn.onClick.AddListener(() =>
        {
            Time.timeScale = 1.0f;

            SceneController.S_Controller.OpenScene("Main");
            EventManager.SendEvent("InGame :: Init");
        });
    }
}
