using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ie6_c : MonoBehaviour
{
    Shader myShader;       
    Material myMaterial;

    public bool InvertEffect;
    public bool DepthEffect;

    void Start()
    {
        myShader = Shader.Find("shader/eval/ie6");    
        myMaterial = new Material(myShader);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (InvertEffect)
        {
            Graphics.Blit(source, destination, myMaterial, 0);
        }
        else if (DepthEffect)
        {
            Graphics.Blit(source, destination, myMaterial, 1);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }
}