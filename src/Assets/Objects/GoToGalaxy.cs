using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class GoToGalaxy : MonoBehaviour
{
    // Start is called before the first frame update
    public bool MouseDown = false;
    public void OnMouseDownOnRight()
    {
        MouseDown = true;
    }
    public void OnMouseUp()
    {
        MouseDown = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("Galaxy");
        }
    }
}
