using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    private static SceneController sController;

    public static SceneController S_Controller
    {
        get
        {
            if (sController == null) sController = FindObjectOfType<SceneController>();
            return sController;
        }
    }

    public void OpenScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}