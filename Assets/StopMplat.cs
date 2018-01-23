using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMplat : MonoBehaviour {
    public bool StopMPlat;
    static Animator animatStopMPlat;

    void OnTriggerEnter()
    {
        
            animatStopMPlat.SetBool("StopMPlat", true);

       
        
        

    }
}
