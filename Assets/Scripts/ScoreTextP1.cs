using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextP1 : MonoBehaviour {

	private Text Player1ScoreText;
	// Use this for initialization
	void Start () {
		Player1ScoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		Player1ScoreText.text = GameObject.FindWithTag ("P1").GetComponent<PlayerControllerP1> ().Score.ToString ();
	}
}
