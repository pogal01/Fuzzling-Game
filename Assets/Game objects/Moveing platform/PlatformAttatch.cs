using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttatch : MonoBehaviour { 

    public GameObject Object;
    public GameObject ThePlayer;
    public GameObject EmptyObject;
   // public GameObject FrontCam;
    public GameObject Backcam;
    

    void OnTriggerEnter()
    {
        ThePlayer.transform.parent = EmptyObject.transform;
        //FrontCam.transform.parent = EmptyObject.transform;
        Backcam.transform.parent = EmptyObject.transform;




    }


}
