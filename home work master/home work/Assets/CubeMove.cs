using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {
	public Rigidbody rg;
	public float velocity;
	// Use this for initialization
	void Start () {
		rg.velocity = new Vector3 (velocity,0,0);
		//rg.AddForce(new vector3(-1,0,0));
		//rg.AddForce(-1,0,0);//Addforce แรงกระทบ
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

