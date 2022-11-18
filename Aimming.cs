using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimming : MonoBehaviour
{
   
    private Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray cameraRay = mainCam.ScreenPointToRay(Input.mousePosition);     //casting ray from camera on mouse input
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);            //creating plane for raycsting

        float raylength; // lenth of the ray we casting from the camera

        if (groundPlane.Raycast(cameraRay, out raylength))
        {
            Vector3 pointtoLook = cameraRay.GetPoint(raylength);  //getting point where exactly our cusor is
            transform.LookAt(new Vector3(pointtoLook.x, transform.position.y, pointtoLook.z));  //making the player to look at the cursor
        }

        

    }
}
