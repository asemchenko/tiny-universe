using System;
using System.Collections;
using System.Collections.Generic;
using model;
using ResourceListControllers;
using UnityEngine;

public class CraftMenuController : MonoBehaviour
{
    public GameObject inventaryListManager;
    private InventaryListController _inventaryListController;

    public void Start()
    {
        _inventaryListController = inventaryListManager.GetComponent<InventaryListController>();
    }

    public void setInventaryResources(List<IResource> resources)
    {
        Debug.Log("Setting available resources from craft menu controller");
        foreach (var resource in resources)
        {
            Debug.Log("Appending resource to inventary list controller...");
            _inventaryListController.appendResource(resource);
        }
    }
}