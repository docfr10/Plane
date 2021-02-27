using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    public void Start()
    {
        //Screen.fullScreen = false;
        Screen.SetResolution(640, 480, false);
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
