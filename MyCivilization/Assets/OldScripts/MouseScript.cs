using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{

    public GameObject particle;
    public GameObject BuildMenue;
    public BuildMenueController buildMenueController;
    Vector3 V3mousePosition;


    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            MouseClick();
        }
    }

    void MouseClick()
    {
        Debug.Log("Did sth");
        
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Physics.Raycast(ray,out hit))
        //{
        //    Debug.Log("Did even more");
        //    Instantiate(particle, hit.point, hit.transform.rotation);
        //}

        if (Physics.Raycast(ray, out hit))
        {
            V3mousePosition =Input.mousePosition;
            V3mousePosition.z = 10;
            buildMenueController.FadeIn(Camera.main.ScreenToWorldPoint(V3mousePosition));
            //Debug.Log("The hitpoint:" + hit.point);
        }
       
        Debug.Log(hit.collider.gameObject.name);

    }
}
