using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPlatformDetach : MonoBehaviour {

    public GameObject Theplayer;
    public GameObject FrontCam;
    public GameObject BackCam;
    public GameObject BackCamPlace;
    //public GameObject FrontCamPlace;
    //public GameObject Platform;
    public bool StopAnimat = false;
    //public GameObject Detachplat;



   

    void Start()
    {
        GameObject.FindGameObjectsWithTag("DPlat");
        StopAnimat = false;
    }

    void Update()
    {
        if (StopAnimat == true)
        {


        }

    }


        private void OnTriggerEnter()
    {
        if (Theplayer)
        {

        Theplayer.transform.parent = null;
        FrontCam.transform.parent = Theplayer.transform;
        BackCam.transform.parent = BackCamPlace.transform;

        StopAnimat = true;




        }
    }
}

