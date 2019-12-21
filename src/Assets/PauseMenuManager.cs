using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    private bool _paused;
    private bool _craftMenuOpened;
    public GameObject pauseMenuUi;
    public GameObject craftMenu;
    public ResourceManager resourceManager;
    private CraftMenuController _craftMenuController;
    // Start is called before the first frame update
    public void Start()
    {
        _paused = false;
        pauseMenuUi.SetActive(false);
        _craftMenuOpened = false;
        craftMenu.SetActive(false);
        _craftMenuController = craftMenu.GetComponent<CraftMenuController>();
        Debug.Log("PauseMenuManager initialization finished");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_craftMenuOpened)
            {
                CloseCraftMenu();
                StartCoroutine(waiter());
            }
            else if (!_paused)
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
        _paused = false;
        Debug.Log("Start game resume");
        Time.timeScale = 1f;
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
    
    public void OpenCraftMenu()
    {
        _craftMenuOpened = true;
        craftMenu.SetActive(true);
        Debug.Log("Setting inventary resources from PauseMenuManager...");
        _craftMenuController.setInventaryResources(resourceManager.getAvailableResources());
    }

    public void CloseCraftMenu()
    {
        craftMenu.SetActive(false);
        _craftMenuOpened = false;
    }
    
    IEnumerator waiter()
    {
        //Rotate 90 deg
        transform.Rotate(new Vector3(90, 0, 0), Space.World);

        //Wait for 4 seconds
        yield return new WaitForSeconds(1);

        //Rotate 40 deg
        transform.Rotate(new Vector3(40, 0, 0), Space.World);
        
        //Rotate 20 deg
        transform.Rotate(new Vector3(20, 0, 0), Space.World);
    }
}
