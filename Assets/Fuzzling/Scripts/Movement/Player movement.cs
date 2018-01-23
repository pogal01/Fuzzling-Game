using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

    public float speed;

    private Rigidbody rigid;
	// Use this for initialization
	void Start () {
		
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float Horizontal = Input.GetAxis("Horizontal");

        float Vertical = Input.GetAxis("Vertical");

        Vector3 Move = new Vector3 (Horizontal, 0.0f, Vertical);

        rigid.AddForce(Move * speed);

    }
}
