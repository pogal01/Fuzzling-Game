using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPlatformDetach : MonoBehaviour {

    public GameObject Theplayer;
    public GameObject FrontCam;
    public GameObject BackCam;
    public GameObject BackCamPlace;
    //public GameObject FrontCamPlace;
    public GameObject Platform;
    public bool StopAnimat = false;
    public Gameobject Detachplat;





    void Start()
    {
        animatSMPlatform = GetComponent<SPlatformAttach>();
    }




    private void OnTriggerEnter()
    {
        if (Theplayer)
        {

        Theplayer.transform.parent = null;
        FrontCam.transform.parent = Theplayer.transform;
        BackCam.transform.parent = BackCamPlace.transform;




         Platform.GetComponent<animatSMPlatform>.Setbool("IPA", false);

        }
    }
}

