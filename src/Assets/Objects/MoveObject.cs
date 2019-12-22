using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public bool MouseDown = false;
    public void OnMouseDown()
    {
        MouseDown = true;
    }
    public void OnMouseUp()
    {
        MouseDown = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 Cursor = Input.mousePosition;
        
        Cursor = Camera.main.ScreenToWorldPoint(Cursor);
        Cursor.z = 0;
        
        if (MouseDown)
        {
            this.transform.position = Cursor;

        }
    }
}
