using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPlatformAttatch : MonoBehaviour {

    static Animator animatSMPlatform;
    public GameObject Object;
    public GameObject ThePlayer;
    public GameObject EmptyObject;
    //comented out because I don't want to use it right now but I might later
    // public GameObject FrontCam;
    public GameObject Backcam;
    public bool PlayerAttached = false;
   


    void Start()
    {
        animatSMPlatform = GetComponent<Animator>();
        PlayerAttached = false;
    }

    void OnTriggerEnter()
    {
        animatSMPlatform.SetBool("IPA", true);
        ThePlayer.transform.parent = Object.transform;
        EmptyObject.transform.parent = ThePlayer.transform;
        //comented out because I don't want to use it right now but I might later
        //FrontCam.transform.parent = EmptyObject.transform;
        Backcam.transform.parent = EmptyObject.transform;
        PlayerAttached = true;
        
    }


}
