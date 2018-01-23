﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDetach : MonoBehaviour {

    public GameObject Theplayer;
    public GameObject FrontCam;
    public GameObject BackCam;
    

    private void OnTriggerEnter()
    {
        Theplayer.transform.parent = null;
        FrontCam.transform.parent = Theplayer.transform;
        BackCam.transform.parent = Theplayer.transform;
    }
}
