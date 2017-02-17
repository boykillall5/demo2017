using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour {
	public Rigidbody rg;
	public float velocity;
	// Use this for initialization
	void Start () {
		rg.velocity = new Vector3 (-1,0,0);
		//rg.AddForce(new vector3(-1,0,0));
		//rg.AddForce(-1,0,0);//Addforce แรงกระทบ

	}
	int countCollosion = 0 ;
	void OnCollisionEnter(Collision collision){
		Debug.LogFormat ("collision is {0} ", collision.gameObject.tag);//แจ้งเตือนการ กระทบสิ่งใดสิ่งหนึ่ง
		 if (collision.gameObject.tag == "Ball") {
			Destroy (gameObject);
		}else if (collision.gameObject.tag == "Ceil") {
			Destroy (gameObject);
		}
	
	}
		
	// Update is called once per frame
	void Update () {

	}
}

