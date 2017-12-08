using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public GameObject scoreText;
	public GameObject gameOverText;
	private int score = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("count", 5, 3);	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.GetComponent<Text> ().text = "score:"+score.ToString();
	}

	private void count(){
		score++;
	}

	public void GameOver(){
		gameOverText.GetComponent<Text> ().text = "GameOver";

	}
		
}
