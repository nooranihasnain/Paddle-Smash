using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text Score;
	public Text Lives;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Score.text = GameObject.FindWithTag ("P1").GetComponent<PlayerControllerP1BREAKOUT> ().Score.ToString ();
		Lives.text = GameObject.FindWithTag ("P1").GetComponent<PlayerControllerP1BREAKOUT> ().Lives.ToString ();
	}
}
