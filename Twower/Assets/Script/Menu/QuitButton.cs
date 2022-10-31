using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    public void StartGame()
    {
        Debug.Log("starting");
        SceneManager.LoadScene("SampleScene");
    }
}