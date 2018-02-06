using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPlatformDetach : MonoBehaviour {

    public GameObject Theplayer;
    public GameObject FrontCam;
    public GameObject BackCam;
    public GameObject BackCamPlace;
    //public GameObject FrontCamPlace;
    static Animator animatSMPlatform;
    public GameObject Platform;






    void Start()
    {
        animatSMPlatform = GetComponent<Animator>();
    }




    private void OnTriggerEnter()
    {
        if (Theplayer)
        {

        Theplayer.transform.parent = null;
        FrontCam.transform.parent = Theplayer.transform;
        BackCam.transform.parent = BackCamPlace.transform;




            Platform.animation.setbool("IPA", true);

        }
    }
}

