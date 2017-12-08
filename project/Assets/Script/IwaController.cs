using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IwaController : MonoBehaviour {

	float rotSpeed;

	void Start () {
		
	}

	void Update () {
		this.transform.Translate (-0.1f, 0, 0);
		if (transform.position.x < -6.5f) {
			Destroy (this.gameObject);
		}
	}

}
