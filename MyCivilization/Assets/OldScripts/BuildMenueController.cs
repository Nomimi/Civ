using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildMenueController : MonoBehaviour {

    public CanvasGroup cg;

    public float smoothTime = 0.2F;
    private float refVelocity = 1.0F;
    private float mouseBorder = 80;
    bool smoothingOut = false;
    bool smoothingIn = false;
    Grid gridScript;
    BuildingList buildingListScript;

   

    Vector3 planedPosition;
    // Use this for initialization
    void Start() {

        gridScript = GetComponent<Grid>();
        
        buildingListScript = GetComponent<BuildingList>();
    }

    // Update is called once per frame
    void Update() {
        if ((Input.mousePosition.x>this.transform.position.x + 280 || Input.mousePosition.x < this.transform.position.x - 250) && !smoothingIn)
        {
            FadeOut();
        }

        if ((Input.mousePosition.y > this.transform.position.y + 230 || Input.mousePosition.y < this.transform.position.y - 230) && !smoothingIn)
        {
            FadeOut();
        }

        //Debug.Log("In:" + smoothingIn);
        //Debug.Log("Out:" + smoothingOut);
    }

    public void FadeIn(Vector3 WindowPosition)
    {
       // planedPosition = gridScript.GetNearestPointOnGrid(WindowPosition);
        Debug.Log("Planned Position: " + planedPosition);
        Debug.Log("Window Position: " + WindowPosition);
        if (!smoothingOut)
            StartCoroutine(SmoothFadeIn());
        
    }

    void FadeOut()
    {
       
        StartCoroutine(SmoothFadeOut());

    }

    IEnumerator SmoothFadeIn()
    {
        smoothingIn = true;

        cg.gameObject.transform.position = Input.mousePosition - new Vector3(-200, 150, 0);
        while (cg.alpha < 1) {
            cg.alpha = Mathf.SmoothDamp(cg.alpha, 1.5f, ref refVelocity, smoothTime);
           
            yield return 0;
        }
        smoothingIn = false;
    }

    IEnumerator SmoothFadeOut()
    {
        smoothingOut = true;
        while (cg.alpha > 0)
        {
         
            cg.alpha = Mathf.SmoothDamp(cg.alpha, -0.5f, ref refVelocity, smoothTime);
            yield return 0;
        }

        smoothingOut = false;
    }

    public void Build()
    {


       // buildingListScript.Build(planedPosition);

    }
}
