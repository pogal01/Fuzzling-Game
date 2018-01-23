using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1End : MonoBehaviour {


    static Animator animatGoal;
    public GameObject Goal;
    public GameObject ThePlayer;
    public bool CheckPoint1 = false;


	// Use this for initialization
	void Start () {
        animatGoal = GetComponent<Animator>();
        CheckPoint1 = false;
	}

    // what to do when the Trigger is Triggerd.
    void OnTriggerEnter()

    {
        CheckPoint1 = true;
        animatGoal.SetBool("HasFin1", true);
        ThePlayer.transform.parent = Goal.transform;
       

    }
	
}
