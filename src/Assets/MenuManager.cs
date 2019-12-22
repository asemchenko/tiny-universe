using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private bool _craftMenuIsOpened = false;
    public GameObject craftMenu;

    
    void Start()
    {
        craftMenu.SetActive(false);
    }
    public void OpenCraftMenu()
    {
        _craftMenuIsOpened = true;
        craftMenu.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _craftMenuIsOpened)
        {
            craftMenu.SetActive(false);
            _craftMenuIsOpened = false;
        }
    }
}