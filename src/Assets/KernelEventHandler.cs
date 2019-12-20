using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KernelEventHandler : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked on kernel!");
        var menuManager = GameObject.Find("PauseMenuManager").GetComponent<PauseMenuManager>();
        menuManager.OpenCraftMenu();
    }
}
