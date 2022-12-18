using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HYS_dice5 : MonoBehaviour
{
    Vector3 V0, V1, V2, V3;
    Vector3[] newVertices;
    int[] newTriangles;

    public Texture Dice;

    Vector2 UV0, UV1, UV2, UV3;
    Vector2[] newUVs;

    void Start()
    {
        V0 = new Vector3(0, 0, 0); // quad의 정점좌표, 좌측하단 uv좌표
        V1 = new Vector3(0, 1, 0);
        V2 = new Vector3(1, 1, 0);
        V3 = new Vector3(1, 0, 0);

        newVertices = new Vector3[]{
            V0, V1, V2, V3
        };

        newTriangles = new int[]{
        0, 1, 2,
        0, 2, 3
        };

        UV0 = new Vector2(0.5f, 0.666f); //uv좌표 정해주기, 0과 1은 범위를 나타냄 uv값 조정해 원하는 부분만 보이도록 할 수 있음
        UV1 = new Vector2(0.5f, 1.0f); //자세한 내용은 week14수업자료에 설명 참고
        UV2 = new Vector2(0.75f, 1.0f);
        UV3 = new Vector2(0.75f, 0.666f);

        newUVs = new Vector2[]
        {
            UV0, UV1, UV2, UV3
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
        mesh.uv = newUVs;

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        DefaultMaterial.mainTexture = Dice;
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;
    }
}

