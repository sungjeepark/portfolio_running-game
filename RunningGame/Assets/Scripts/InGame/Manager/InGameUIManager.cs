using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Image bar;
    [SerializeField] private Button quitBtn;

    [SerializeField] private GameObject player;
    [SerializeField] private Transform deadZone;

    [SerializeField] private Vector3 deadZoneOffset;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer.Equals(LayerMask.NameToLayer("DeadZone")))
        {
            Debug.Log("ав╬Н╤С~");
            Destroy(player);
            SceneController.S_Controller.OpenScene("Main");
        }


    }
    private void Awake()
    {
        LoadSceneAdditive();

        quitBtn.onClick.AddListener(() =>
        {
            SceneController.S_Controller.OpenScene("Main");
        });

        //bar.fillAmount = 1f;
    }

    void LateUpdate()
    {
        scoreText.text = string.Format("{0:N0}", ScoreManager.Instance.GetScore());
        bar.fillAmount = InGameManager.Instance.player.GetHpNormalized();
    }

    void Start() 
    {
         
    }

    void LoadSceneAdditive() { SceneManager.LoadScene("Stage1", LoadSceneMode.Additive); }

    private void Update()
    {
      deadZone.transform.position = new Vector3(player.transform.position.x,  0) + deadZoneOffset;
   

    }
}
