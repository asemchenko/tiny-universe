using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateObject : MonoBehaviour
{
    public GameObject prefab;
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

    /*void Upload()
    {
        if (MouseDown)
        {
            GameObject result = Instantiate(prefab, new Vector3(3, 0, 0), Quaternion.identity);
            result.GetComponent<MeshRenderer>().sortingOrder = 2;
            SceneManager.MoveGameObjectToScene(result, scene);
        }
    }*/
    


}
