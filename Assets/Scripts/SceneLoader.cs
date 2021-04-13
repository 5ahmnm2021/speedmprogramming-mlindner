using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Scene Manager Marco Lindner

public class SceneLoader : MonoBehaviour
{
    public void LoadScene2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("scene3");
    }

}
