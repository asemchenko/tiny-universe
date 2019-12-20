using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    private bool _paused;
    public GameObject pauseMenuUi;
    // Start is called before the first frame update
    public void Start()
    {
        _paused = false;
        pauseMenuUi.SetActive(false);
        Debug.Log("PauseMenuManager initialization finished");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_paused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    
    public void Pause()
    {
        _paused = true;
        Debug.Log("Start game pause");
        Time.timeScale = 0;
        pauseMenuUi.SetActive(true);
        Debug.Log("Game paused");
    }

    public void Resume()
    {
        Debug.Log("Start game resume");
        Time.timeScale = 1f;
        _paused = false;
        pauseMenuUi.SetActive(false);
        Debug.Log("Game resumed");
    }

    public void toMainMenu()
    {
        if (_paused)
        {
            Resume();
            SceneManager.LoadScene(0);
        }
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
