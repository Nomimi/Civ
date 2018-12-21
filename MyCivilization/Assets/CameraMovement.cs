using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    Vector3 direction;
    Vector3 target;

    public bool mouseCameraMovement = false;
    public float speed = 0.5f;
    // Use this for initialization
    void Start() {
        Vector3 direction = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update() {

        direction = new Vector3(0, 0, 0);

        //Debug.Log(Input.mousePosition);
        
        if (Input.GetKey(KeyCode.D) || (Input.mousePosition.x > (Screen.width / 20)*19 && mouseCameraMovement ))
        {
            direction.x = speed;
        }
        else if (Input.GetKey(KeyCode.A) || (Input.mousePosition.x < (Screen.width/20) && mouseCameraMovement))
        {
            direction.x = -speed;
        }

        if (Input.GetKey(KeyCode.W) || (Input.mousePosition.y > (Screen.height / 10)*9 && mouseCameraMovement))
        {
            direction.z = speed;
        }
        else if (Input.GetKey(KeyCode.S) || (Input.mousePosition.y < (Screen.height/10) && mouseCameraMovement))
        {
            direction.z = -speed;
        }

        else if ((Input.GetAxis("Mouse ScrollWheel") > 0 ))
        {
            direction.y = -speed*5;
        }

        else if ((Input.GetAxis("Mouse ScrollWheel")<0 ))
        {
            direction.y = +speed*5;
        }
        //target = this.transform.position + direction;
        MoveCamera();
    }

    void MoveCamera()
    {
        if (direction.x != 0 || direction.y != 0 || direction.z != 0)
        {
            transform.position += direction;

        } 


    }
}
