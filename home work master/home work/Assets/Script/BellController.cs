using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BellController : MonoBehaviour {
	public Rigidbody rg;
	public float speed;
	public TextMesh txtBall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DoJump(){
		rg.velocity = new Vector3 (0, speed, 0);
	}
	int countCollosion = 0 ;
	void OnCollisionEnter(Collision collision){
		Debug.LogFormat ("collision is {0} ", collision.gameObject.tag);//แจ้งเตือนการ กระทบสิ่งใดสิ่งหนึ่ง
		if (collision.gameObject.tag == "floor") {
			countCollosion++;
			txtBall.text = "Floor :" + countCollosion.ToString ();
		} else if (collision.gameObject.tag == "Ceil") {
			Destroy (gameObject);
		} else if (collision.gameObject.tag == "Cylinder") {
			Destroy (gameObject);
		}
	}
}
