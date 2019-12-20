using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Button click handlers for main menu
 */
public class UiManager : MonoBehaviour
{
    void Start()
    {
//        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void Update()
    {
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
    
}