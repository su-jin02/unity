using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene2 : MonoBehaviour
{
    private void Start()
    {
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Scene_Kang");
    }
}



