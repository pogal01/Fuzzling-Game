using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachedplat2 : MonoBehaviour
{
    public GameObject Object;
    public GameObject ThePlayer;
    static Animator AnimatStopPlat2;
    public bool attached = false;

    // public GameObject FrontCam;


    //Use this to change things as soon as the game starts
    void Start()
    {
        AnimatStopPlat2 = GetComponent<Animator>();
        attached = false;
        AnimatStopPlat2.SetBool("StopMPlat", true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            ThePlayer.transform.parent = Object.transform;
            AnimatStopPlat2.SetBool("StopMPlat", false);
            attached = true;


        }



    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
         AnimatStopPlat2.SetBool("StopMPlat", true);
        attached = false;
        ThePlayer.transform.parent = null;
    }

}