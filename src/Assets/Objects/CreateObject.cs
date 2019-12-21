using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateObject : MonoBehaviour
{
    public GameObject prefab;
    public Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        GameObject result = Instantiate(prefab, new Vector3(3, 0, 0), Quaternion.identity);
        result.GetComponent<MeshRenderer>().sortingOrder = 2;
        SceneManager.MoveGameObjectToScene(result, scene);
    }


}
