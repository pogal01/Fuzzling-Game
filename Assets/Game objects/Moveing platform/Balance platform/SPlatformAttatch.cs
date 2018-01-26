using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPlatformAttatch : MonoBehaviour { 

    public GameObject Object;
    public GameObject ThePlayer;
    public GameObject EmptyObject;
   // public GameObject FrontCam;
    public GameObject Backcam;
    public GameObject Platform;
    public GameObject Rotation;
    

    void OnTriggerEnter()
    {

        
        ThePlayer.transform.parent = EmptyObject.transform;
        EmptyObject.transform.parent = ThePlayer.transform;
        //FrontCam.transform.parent = EmptyObject.transform;
        Backcam.transform.parent = EmptyObject.transform;
        ThePlayer.transform.parent = Rotation.transform;







    }


}
