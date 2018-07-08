using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomColliderScript : MonoBehaviour {

	public GameObject Ball;
	public GameObject YouLose;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D Col)
	{
		if (Col.gameObject.CompareTag ("Brick")) {
			Destroy (Col.gameObject);
		}
		if (Col.gameObject.CompareTag ("Ball")) {
			Destroy (Col.gameObject);
			GameObject.FindWithTag ("P1").GetComponent<PlayerControllerP1BREAKOUT> ().Lives -= 1;
			Invoke ("SpawnBall", 1.5f);
		}
		int RemainingLives = GameObject.FindWithTag ("P1").GetComponent<PlayerControllerP1BREAKOUT> ().Lives;
		if (RemainingLives <= 0) {
			YouLose.SetActive (true);
			Invoke ("LoadRetryScreen", 1f);
		}
	}

	void LoadRetryScreen()
	{
		Initiate.Fade ("GameOverBREAKOUT", Color.black, 3f);
	}

	void SpawnBall()
	{
		Vector2 Pos = new Vector2 (0f, -1.5f);
		Quaternion Rot = Quaternion.Euler (0, 0, 0);
		Instantiate (Ball, Pos, Rot);
	}
}
