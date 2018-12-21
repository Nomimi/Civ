using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouseover : MonoBehaviour {

    MeshRenderer mesh_renderer;
    Color originalColor;
	// Use this for initialization
	void Start () {
        mesh_renderer = GetComponent<MeshRenderer>();
        originalColor = mesh_renderer.material.color;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        mesh_renderer.material.color = Color.blue;
    }

    private void OnMouseExit ()
    {
        mesh_renderer.material.color = originalColor;
    }
}
