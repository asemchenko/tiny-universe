using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene newScene = SceneManager.CreateScene("Space");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
