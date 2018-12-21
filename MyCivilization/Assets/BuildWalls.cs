using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class BuildWalls : MonoBehaviour { 

//    //int size_x = 100;
//    //int size_z = 50;

//    // Use this for initialization
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        BuildMesh();
//    }

//    void BuildMesh()
//    {
//        int numTiles = (int)Input.mousePosition.x;
//        int numTris = numTiles * 2;

//        int vsize_x = (int)Input.mousePosition.x + 1;
//        int vsize_z = (int)Input.mousePosition.x + 1; ;
//        int numVerts = vsize_x + vsize_z;


//        //// Generate Meta Data
//        Vector3[] vertices = new Vector3[numVerts];
//        int[] triangles = new int[numTiles * 3];
//        Vector3[] normals = new Vector3[numVerts];
//        Vector2[] uv = new Vector2[numVerts];

//        int x, z;


       
//            for (x = 0; x < (int)Input.mousePosition.x; x++)
//            {
//             vertices[x] = new Vector3(x, 0, 0);

        

//             }

//        for (x = 0; x < (int)Input.mousePosition.x; x++)
//        {
//            vertices[(int)Input.mousePosition.x+x] = new Vector3(x, 3, 0);



//        }
//        for (int nt = 0; nt < numTris; nt++)
//        {
           
//                if (nt % 2 == 0)
//                {
//                    triangles[nt * 3 ] = (int)vertices[nt].x;
//                    triangles[nt * 3 + 1] = (int)vertices[nt+1].x;
//                    triangles[nt * 3 + 2] = (int)vertices[nt + (int)Input.mousePosition.x].x;
//            }
//                else
//                {
//                    triangles[nt * 3] = 0;
//                    triangles[nt * 3 + 1] = 3;
//                    triangles[nt * 3 + 2] = 2;
//            }
                
            
//        }

//        for (int n = 0; n < numVerts; n++)
//        { normals[n] = Vector3.right; }

//        //// HardCoded Plane
//        //vertices[0] = new Vector3(0, 0, 0);
//        //vertices[1] = new Vector3(1, 0, 0);
//        //vertices[2] = new Vector3(0, 0, -1);
//        //vertices[3] = new Vector3(1, 0, -1);

//        //triangles[0] = 0;
//        //triangles[1] = 3;
//        //triangles[2] = 2;

//        //triangles[3] = 0;
//        //triangles[4] = 1;
//        //triangles[5] = 3;

//        //normals[0] = Vector3.up;
//        //normals[1] = Vector3.up;
//        //normals[2] = Vector3.up;
//        //normals[3] = Vector3.up;

//        //uv[3] = new Vector2(0, 0);
//        //uv[3] = new Vector2(1, 0);
//        //uv[3] = new Vector2(0, 1);
//        //uv[3] = new Vector2(1, 1);

//        // Create mesh and insert the data
//        Mesh mesh = new Mesh();
//        mesh.vertices = vertices;
//        mesh.triangles = triangles;
//        mesh.normals = normals;

//        // Assign created mesh to filter
//        MeshFilter mesh_filter = GetComponent<MeshFilter>();
//        MeshRenderer mesh_renderer = GetComponent<MeshRenderer>();
//        MeshCollider mesh_collider = GetComponent<MeshCollider>();
//        mesh_filter.mesh = mesh;





//    }
}

