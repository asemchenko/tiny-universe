using System.Collections.Generic;
using model;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This script is used to place game object ( star / planet ) at the scene
 * By attaching this script to any GameObject it will follow mouse cursor
 * until left mouse button is clicked. After that object is placed
 */
public class ObjectPlacementScript : MonoBehaviour
{
    public static bool isPresentUnplacedObject = false;
    public static SpriteType unplacedObject;
    private bool _isPlaced = false;

    public static void markStarUnplaced()
    {
        unplacedObject = SpriteType.STAR;
        isPresentUnplacedObject = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!_isPlaced)
        {
            // checking if left mouse button is clicked
            if (Input.GetMouseButtonDown(0))
            {
                if (SceneManager.GetActiveScene().name.Equals("Galaxy"))
                {
                    Debug.Log("[Object Placement Script] Committing object at the scene");
                    _isPlaced = true;
                    isPresentUnplacedObject = false;
                }
            }
            else
            {
                Debug.Log("[Object Placement Script] Following mouse position");
                transform.position = new Vector3(Input.mousePosition.x - 50, Input.mousePosition.y - 50);
            }
        }
    }
}

public enum SpriteType
{
    STAR,
    PLANET
}