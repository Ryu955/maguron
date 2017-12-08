using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IwaGenerator : MonoBehaviour {

	public GameObject[] rocks = new GameObject[3];
	private int num;

	// Use this for initialization
	void Start () {
		 num = Random.Range (0, rocks.Length);
		InvokeRepeating ("GenRock", 1, 3);
	}
	
	// Update is called once per frame
	void Update () {
		num = Random.Range (0, rocks.Length);
	}

	void GenRock () {
//		Instantiate (GameObject[num], new Vector3 (-2.5f + 5 * Random.value, 6, 0), transform.rotation);
		Instantiate(rocks[num],new Vector3 (10f, -5f, -1f),transform.rotation);
	}
}
