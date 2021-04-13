using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Scene Manager Marco Lindner

public class sceneLoader : MonoBehaviour
{
    public void LoadColorScene()
    {
        SceneManager.LoadScene("scene2");
    }

    public void LoadNumberScene()
    {
        SceneManager.LoadScene("scene3");
    }

}