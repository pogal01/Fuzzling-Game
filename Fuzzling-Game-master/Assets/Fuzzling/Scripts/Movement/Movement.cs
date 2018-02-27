using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float MoveS;

	// Use this for initialization
	void Start () {
        MoveS = 40f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(MoveS * Input.GetAxis( "Horizontal") * Time.deltaTime, 0f,  MoveS * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
