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
    public GameObject craftListManager;
    private CraftListController _craftListController;

    public void Start()
    {
        _inventaryListController = inventaryListManager.GetComponent<InventaryListController>();
        _craftListController = craftListManager.GetComponent<CraftListController>();
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

    public void moveResourceToCraft(ListController.ResourceDescriptor descriptor)
    {
        if (_inventaryListController.DecrementResource(descriptor))
        {
            Debug.Log("Moving resource from inventory to craft area");
            _craftListController.appendResource(descriptor.resource.GetOneUnit());
        }
    }

    public void moveResourceToInventary(ListController.ResourceDescriptor descriptor)
    {
        if (_craftListController.DecrementResource(descriptor))
        {
            Debug.Log("Moving resource from inventory to craft area");
            _inventaryListController.appendResource(descriptor.resource.GetOneUnit());
        }
    }
}