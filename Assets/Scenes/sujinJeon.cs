using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sujinJeon : MonoBehaviour
{
    Vector3 v0, v1, v2, v3;
    Vector3[] newVertices;
    int[] newTriangles;

    public Texture Dice;

    Vector2 uv0, uv1, uv2, uv3;
    Vector2[] newuvs;

    void Start()
    {
        v0 = new Vector3(0, 0, 0);
        v1 = new Vector3(0, 1, 0);
        v2 = new Vector3(1, 1, 0);
        v3 = new Vector3(1, 0, 0);

        newVertices = new Vector3[] {
        v0,v1,v2,v3 };

        newTriangles = new int[]
        {
            0,1,2,
            0,2,3
        };

        uv0 = new Vector2(0, 0);
        uv1 = new Vector2(0, 1);
        uv2 = new Vector2(1, 1);
        uv3 = new Vector2(1, 0);

        newuvs = new Vector2[]
        {
            uv0, uv1, uv2, uv3
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
        mesh.uv = newuvs;

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        DefaultMaterial.mainTexture = Dice;
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;

    }
}
