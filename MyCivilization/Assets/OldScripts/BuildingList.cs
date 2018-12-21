using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingList : MonoBehaviour {


    public GameObject exampleBuilding;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Build(Vector3 buildingLocation)
    {
        Instantiate(exampleBuilding, buildingLocation, new Quaternion(0, 0, 0, 0));
    }
}
