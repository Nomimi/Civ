using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMapScript : MonoBehaviour {

    public Material[] hexMaterials;
    public GameObject HexPrefab;

    int numRows = 20;
    int numColumns = 40;
	// Use this for initialization
	void Start () {
        GenerateMap();
	}

    
    // Update is called once per frame
    void GenerateMap()
    {
        for (int column = 0; column < numColumns; column++)
        {
            for (int row = 0; row < numRows; row++)
            {
                //Instandiate a Hex
                Hex h = new Hex(column, row);

                GameObject hexGO = (GameObject)Instantiate(
                HexPrefab,
                h.Position(),
                Quaternion.identity,
                this.transform
                );

                MeshRenderer mr = hexGO.GetComponentInChildren<MeshRenderer>();
                mr.material = hexMaterials[Random.Range(0, hexMaterials.Length)];


            }

        }
    }
}
