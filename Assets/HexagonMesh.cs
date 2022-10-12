using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
        mesh.vertices = new Vector3[]{
            new Vector3(Mathf.Sin(1.0f * Mathf.PI / 3.0f), 0f, Mathf.Cos(1.0f * Mathf.PI / 3.0f)),
            new Vector3(Mathf.Sin(2.0f * Mathf.PI / 3.0f), 0f, Mathf.Cos(2.0f * Mathf.PI / 3.0f)),
            new Vector3(Mathf.Sin(3.0f * Mathf.PI / 3.0f), 0f, Mathf.Cos(3.0f * Mathf.PI / 3.0f)),
            new Vector3(Mathf.Sin(4.0f * Mathf.PI / 3.0f), 0f, Mathf.Cos(4.0f * Mathf.PI / 3.0f)),
            new Vector3(Mathf.Sin(5.0f * Mathf.PI / 3.0f), 0f, Mathf.Cos(5.0f * Mathf.PI / 3.0f)),
            new Vector3(Mathf.Sin(6.0f * Mathf.PI / 3.0f), 0f, Mathf.Cos(6.0f * Mathf.PI / 3.0f)),
        };
        mesh.triangles = new int[]{
            0, 4, 5,
            0, 2, 4,
            0, 1, 2,
            2, 3, 4
        };

        var renderer = gameObject.GetComponent<MeshRenderer>();
        var flatTexture = new Texture2D(1, 1);
        flatTexture.SetPixel(0, 0, Color.green);
        renderer.material.mainTexture = flatTexture;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
