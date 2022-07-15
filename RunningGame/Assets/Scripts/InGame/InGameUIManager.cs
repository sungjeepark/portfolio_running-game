using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private Button quitBtn;

    private void Awake()
    {
        quitBtn.onClick.AddListener(() =>
        {
            SceneController.S_Controller.OpenScene("Main");
        });
    }
    void Start() 
    {
        LoadSceneAdditive(); 
    }

    void LoadSceneAdditive() { SceneManager.LoadScene("Stage1", LoadSceneMode.Additive); }
}
