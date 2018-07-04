using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderP1SP : MonoBehaviour {

	public GameObject Ball;
	public CameraShake CamShake;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D Col)
	{
		GameObject Player = GameObject.FindWithTag ("P2");
		if (Col.gameObject.CompareTag ("Ball")) {
			Player.GetComponent<AIScript> ().Score += 1;
			Destroy (Col.gameObject);
			GameObject.FindWithTag ("OutlineP2-1").GetComponent<OutlineScriptP2> ().OutlineSpeed = Player.GetComponent<AIScript> ().Score;
			GameObject.FindWithTag ("OutlineP2-2").GetComponent<OutlineScriptP2> ().OutlineSpeed = Player.GetComponent<AIScript> ().Score;
			Invoke ("SpawnBall", 3f);
			StartCoroutine (CamShake.ShakeCam (0.15f, 0.15f));
		}
	}

	void SpawnBall()
	{
		Vector2 SpawnLoc = new Vector2 (0, 0);
		Quaternion SpawnRot = Quaternion.Euler (0, 0, 0);
		GameObject BallInst = Instantiate (Ball, SpawnLoc, SpawnRot);
		BallInst.GetComponent<BallScript> ().IsLeft = false;
	}
}
