using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPlatformDetach : MonoBehaviour {

    public GameObject Theplayer;
    public GameObject FrontCam;
    public GameObject BackCam;
    public GameObject BackCamPlace;
    //public GameObject FrontCamPlace;


    private void OnTriggerEnter()
    {
        Theplayer.transform.parent = null;
        FrontCam.transform.parent = Theplayer.transform;
        BackCam.transform.parent = Theplayer.transform;

        GameObject.Find ("Swaying Trigger").GetComponent<SPlatformAttatch>().
        if (GameObject.Find("Swaying Trigger").GetComponent<SPlatformAttatch>().PlayerAttached)
        {
            animatSMPlatform.SetBool("IPA", false);

        }
            ;
    }
}
