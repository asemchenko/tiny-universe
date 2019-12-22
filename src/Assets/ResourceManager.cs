using System;
using System.Collections.Generic;
using System.Linq;
using model;
using UnityEngine;
using UnityEngine.UI;
using Space = model.Space;
using Time = model.Time;

/**
 * This script is used to manage resource. All resources should be updated only via this script, not directly!
 */
public class ResourceManager : MonoBehaviour
{
    // real resource values
    private long _energyResourceAmount;
    private long _spaceResourceAmount;
    private long _substanceResourceAmount;

    private long _timeResourcesAmount;

    // resource view pointers
    public Text energyResourceText;
    public Text spaceResourceText;
    public Text substanceResourceText;
    public Text timeResourceText;

    // resource properties
    public long TimeResourceAmount
    {
        get => _timeResourcesAmount;
        set
        {
            timeResourceText.text = value.ToString();
            _timeResourcesAmount = value;
        }
    }

    public long SpaceResourceAmount
    {
        get => _spaceResourceAmount;
        set
        {
            spaceResourceText.text = value.ToString();
            _spaceResourceAmount = value;
        }
    }

    public long SubstanceResourceAmount
    {
        get => _substanceResourceAmount;
        set
        {
            substanceResourceText.text = value.ToString();
            _substanceResourceAmount = value;
        }
    }

    public long EnergyResourceAmount
    {
        get => _energyResourceAmount;
        set
        {
            energyResourceText.text = value.ToString();
            _energyResourceAmount = value;
        }
    }

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("Initializing resources");
        TimeResourceAmount = 300;
        SpaceResourceAmount = 200;
        SubstanceResourceAmount = 0;
        EnergyResourceAmount = 0;
    }

    public List<IResource> getAvailableResources()
    {
        var resources = new List<IResource>();
        resources.Add(new Energy(_energyResourceAmount));
        resources.Add(new model.Space(_spaceResourceAmount));
        resources.Add(new Substance(_substanceResourceAmount));
        resources.Add(new model.Time(_timeResourcesAmount));
        Debug.Log("Getting available resources: " + resources);
        Debug.Log("Available resources size: " + resources.Count);
        return resources;
    }

    public void wasteResources(List<IResource> resourcesToBeWasted)
    {
        foreach (var resource in resourcesToBeWasted)
        {
            wasteResource(resource);
        }
    }

    public void wasteResource(IResource resource)
    {
        Debug.Log("Wasting resource: " + resource.GetResourceName() + " " + resource.GetResourceAmount().ToString());
        var type = resource.GetType();
        if (type.Equals(typeof(Time)))
        {
            TimeResourceAmount = TimeResourceAmount - resource.GetResourceAmount();
        } else if (type.Equals(typeof(Space)))
        {
            SpaceResourceAmount = SpaceResourceAmount - resource.GetResourceAmount();
        } else if (type.Equals(typeof(Substance)))
        {
            SubstanceResourceAmount = SubstanceResourceAmount - resource.GetResourceAmount();
        } else if (type.Equals(typeof(Energy)))
        {
            EnergyResourceAmount = EnergyResourceAmount - resource.GetResourceAmount();
        }
    }

    public void addResource(IResource resource)
    {
        var type = resource.GetType();
        if (type.Equals(typeof(Time)))
        {
            TimeResourceAmount = TimeResourceAmount + resource.GetResourceAmount();
        } else if (type.Equals(typeof(Space)))
        {
            SpaceResourceAmount = SpaceResourceAmount + resource.GetResourceAmount();
        } else if (type.Equals(typeof(Substance)))
        {
            SubstanceResourceAmount = SubstanceResourceAmount + resource.GetResourceAmount();
        } else if (type.Equals(typeof(Energy)))
        {
            EnergyResourceAmount = EnergyResourceAmount + resource.GetResourceAmount();
        }
    }

    // Update is called once per frame
    public void Update()
    {
    }
}