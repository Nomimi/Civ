using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildOnHex : MonoBehaviour {

    public Camera cam;
    public GameObject TestBuilding;

    BuildMenueController Build_Menue_Controller;
    // Use this for initialization
    void Start () {
        Build_Menue_Controller = GetComponent<BuildMenueController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("mouse");
            
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            { Debug.Log(hit.transform.name);
                Debug.Log("col");


                Build_Menue_Controller.FadeIn(hit.transform.position);
                Instantiate(TestBuilding, hit.transform.position, Quaternion.identity);
            }
                    
                  

        }
	}
}
