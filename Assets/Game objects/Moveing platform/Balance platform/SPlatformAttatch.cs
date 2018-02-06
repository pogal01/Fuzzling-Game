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
    private SPlatformDetach PlatD; 
    

   void Awake()
    {
        PlatD = GetComponent<SPlatformDetach>();


    }

    void Start()
    {
        animatSMPlatform = GetComponent<Animator>();
        PlayerAttached = false;
        animatSMPlatform.SetBool("IPA", false);

    }

    void Update()
    {
        if (PlatD.StopAnimat == true)
        {
            animatSMPlatform.SetBool("IPA", false);
            PlayerAttached = false;
        }

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