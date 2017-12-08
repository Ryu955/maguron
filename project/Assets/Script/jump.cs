using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	public GameObject maguro;

	private Rigidbody2D rigid;
	private float jumpForce = 200f;

	// Use this for initialization
	void Start () {
		rigid = maguro.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void onButton(){
		rigid.AddForce (transform.up * this.jumpForce);
	}
}
