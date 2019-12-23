using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMousePosition : MonoBehaviour
{
    public void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("Following mouse position");
        transform.position = new Vector3(Input.mousePosition.x - 5, Input.mousePosition.y - 5);
    }
}
