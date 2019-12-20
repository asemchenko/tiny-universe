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
        transform.position = Input.mousePosition;
    }
}
