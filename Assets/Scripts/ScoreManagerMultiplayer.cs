using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerMultiplayer : MonoBehaviour {

	public GameObject P1Wins;
	public GameObject P2Wins;

	private GameObject Player1;
	private GameObject Player2;
	// Use this for initialization
	void Start () {
		Player1 = GameObject.FindWithTag ("P1");
		Player2 = GameObject.FindWithTag ("P2");
	}
	
	// Update is called once per frame
	void Update () {
		if (Player1.GetComponent<PlayerControllerP1> ().Score >= 11) {
			P1Wins.SetActive (true);
			Invoke ("LoadGameOverScreen", 1f);

		} 
		else if (Player2.GetComponent<PlayerControllerP2> ().Score >= 11) {
			P2Wins.SetActive (true);
			Invoke ("LoadGameOverScreen", 2f);
		}
	}

	void LoadGameOverScreen()
	{
		UIScript.IsMultiplayer = true;
		Initiate.Fade ("GameOver", Color.black, 1f);
	}
}
