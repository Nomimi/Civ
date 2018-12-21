using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class TileMapScript : MonoBehaviour {

    int size_x = 100;
    int size_z = 50;

	// Use this for initialization
	void Start () {
        BuildMesh();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void BuildMesh()
    {
        int numTiles = size_x * size_z;
        int numTris = numTiles * 2;

        int vsize_x = size_x + 1;
        int vsize_z = size_z + 1;
        int numVerts = vsize_x + vsize_z;


        //// Generate Meta Data
        Vector3[] vertices = new Vector3[numVerts];
        int[] triangles = new int[numTiles * 3];
        Vector3[] normals = new Vector3[numVerts];
        Vector2[] uv = new Vector2[numVerts];

        int x, z;


        for ( z = 0; z < size_z; z++)
        {
            for (x= 0; x < size_x; x++)
            {

                
            }

        }
        //// HardCoded Plane
        //vertices[0] = new Vector3(0, 0, 0);
        //vertices[1] = new Vector3(1, 0, 0);
        //vertices[2] = new Vector3(0, 0, -1);
        //vertices[3] = new Vector3(1, 0, -1);

        //triangles[0] = 0;
        //triangles[1] = 3;
        //triangles[2] = 2;

        //triangles[3] = 0;
        //triangles[4] = 1;
        //triangles[5] = 3;

        //normals[0] = Vector3.up;
        //normals[1] = Vector3.up;
        //normals[2] = Vector3.up;
        //normals[3] = Vector3.up;

        //uv[3] = new Vector2(0, 0);
        //uv[3] = new Vector2(1, 0);
        //uv[3] = new Vector2(0, 1);
        //uv[3] = new Vector2(1, 1);

        // Create mesh and insert the data
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.normals = normals;

        // Assign created mesh to filter
        MeshFilter mesh_filter = GetComponent<MeshFilter>();
        MeshRenderer mesh_renderer = GetComponent<MeshRenderer>();
        MeshCollider mesh_collider = GetComponent<MeshCollider>();
        mesh_filter.mesh = mesh;
   


        

    }
}
