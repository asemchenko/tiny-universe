using UnityEngine;
using UnityEngine.UI;

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
        get => _spaceResourceAmount;
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
        SubstanceResourceAmount = 400;
        EnergyResourceAmount = 100;
    }

    // Update is called once per frame
    public void Update()
    {
    }
}