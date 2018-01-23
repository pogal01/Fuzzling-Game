using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraEvents : MonoBehaviour
{
    [SerializeField]
    Camera camera1;
    [SerializeField]
    Camera camera2;
    [SerializeField]
    Camera camera3;
    //Camera1&2 are my cameras' that switch from third person to side view as i'm //making a 3d version of that jumping block thing.

    private bool switchCam = false;
    private bool backCam = false;

    void Start()
    {

        camera1.GetComponent<Camera>().enabled = true;
        camera2.GetComponent<Camera>().enabled = false;
        camera3.GetComponent<Camera>().enabled = false;

    }


    void Update()
    {

        if (Input.GetKeyUp("f"))
        {
            switchCam = !switchCam;
            backCam = false;
        }
        if (Input.GetKeyUp("g"))
        {
            switchCam = false;
            backCam = true;
        }
      
        if (switchCam == true)
        {
            camera1.GetComponent<Camera>().enabled = false;
            camera2.GetComponent<Camera>().enabled = false;
            camera3.GetComponent<Camera>().enabled = true;
        }
        else if (backCam == true)
        {
            camera1.GetComponent<Camera>().enabled = false;
            camera2.GetComponent<Camera>().enabled = true;
            camera3.GetComponent<Camera>().enabled = false;
        }
        else
        {
            camera1.GetComponent<Camera>().enabled = true;
            camera2.GetComponent<Camera>().enabled = false;
            camera3.GetComponent<Camera>().enabled = false;
        }
    }
}