using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Start()
    {
        //UnityEngine.Debug.Log("LoadSceneA");
    }
    public void Ann()
    {
        UnityEngine.Debug.Log("Annotate" + 6);
        SceneManager.LoadScene(6);
    }
    public void Video()
    {
        UnityEngine.Debug.Log("Video" + 3);
        SceneManager.LoadScene(3);
    }
    public void Back()
    {
        UnityEngine.Debug.Log("MainMenu" + 2);
        SceneManager.LoadScene(2);
    }
    public void French()
    {
        UnityEngine.Debug.Log("FrenchMenu" + 4);
        SceneManager.LoadScene(4);
    }
    public void FrenchAnn()
    {
        UnityEngine.Debug.Log("FrenchAnnotate" + 5);
        SceneManager.LoadScene(5);
    }
}