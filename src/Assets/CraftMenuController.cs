using System;
using System.Collections;
using System.Collections.Generic;
using model;
using ResourceListControllers;
using UnityEngine;
using UnityEngine.UI;

public class CraftMenuController : MonoBehaviour
{
    public InventaryListController _inventaryListController;
    public CraftResultListController _CraftResultListController;
    public ResourceManager resourceManager;
    public GameObject craftListManager;
    public GameObject craftButton;
    private Crafter crafter = new Crafter();
    private CraftListController _craftListController;
    private bool _inventaryFirstlyInitialized = false;

    public void Start()
    {
        _craftListController = craftListManager.GetComponent<CraftListController>();
        craftButton.SetActive(false);
    }

    public void setInventaryResources(List<IResource> resources)
    {
        if (!_inventaryFirstlyInitialized)
        {
            _inventaryFirstlyInitialized = true;
            Debug.Log("Setting available resources from craft menu controller");
            foreach (var resource in resources)
            {
                Debug.Log("Appending resource to inventary list controller...");
                _inventaryListController.appendResource(resource);
            }
        }
    }

    public void moveResourceToCraft(ListController.ResourceDescriptor descriptor)
    {
        if (_inventaryListController.DecrementResource(descriptor))
        {
            Debug.Log("Moving resource from inventory to craft area");
            _craftListController.appendResource(descriptor.resource.GetOneUnit());
            afterMoveEvent();
        }
    }

    public void moveResourceToInventary(ListController.ResourceDescriptor descriptor)
    {
        if (_craftListController.DecrementResource(descriptor))
        {
            Debug.Log("Moving resource from inventory to craft area");
            _inventaryListController.appendResource(descriptor.resource.GetOneUnit());
            resourceManager.Update();
            afterMoveEvent();
        }
    }

    /**
     * Attempts to make craft. If successful - resources from the craft area will be wasted for a new resourse
     */
    public void craft()
    {
        Debug.Log("Start crafting");
        // TODO check for empty of the craft result before any craft
        if (_CraftResultListController.isEmpty())
        {
            // check if craft is possible
            var iResources = _craftListController.getIResources();
            Debug.Log("Check if can be crafted...");
            if (crafter.canBeCrafted(iResources))
            {
                Debug.Log("Crafting...");
                var result = crafter.craft(iResources);
                // removing resources that were wasted for craft operation
                _craftListController.clear();
                // updating resources bar
                resourceManager.wasteResources(iResources);
                // inserting resource to craft result bar
                _CraftResultListController.appendResource(result);
                // updating resource bar
                resourceManager.addResource(result);
            }
        }
    }

    public void afterMoveEvent()
    {
        crafter = new Crafter();
        Debug.Log("Checking if craft is possible...");
        if (_CraftResultListController.isEmpty())
        {
            // check if craft is possible
            var iResources = _craftListController.getIResources();
            if (crafter.canBeCrafted(iResources))
            {
                Debug.Log("Craft is posiible, enabling craft button...");
                craftButton.SetActive(true);
            }
            else
            {
                craftButton.SetActive(false);
            }
        }
    }

    public void moveCraftResultToResources(ListController.ResourceDescriptor descriptor)
    {
        _craftListController.DecrementResource(descriptor);
        _inventaryListController.appendResource(descriptor.resource);
        _CraftResultListController.clear();
    }
}