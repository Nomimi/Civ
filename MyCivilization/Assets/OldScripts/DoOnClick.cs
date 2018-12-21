using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("I got clicked:" + this.gameObject.name);
    }
}
