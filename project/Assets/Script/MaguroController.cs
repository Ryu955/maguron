﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MaguroController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log ("当たった");
//		UIController.GameOver ();
		GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver();
	}



}
