using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderP2 : MonoBehaviour {

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
		GameObject Player = GameObject.FindWithTag ("P1");
		if (Col.gameObject.CompareTag ("Ball")) {
			Player.GetComponent<PlayerControllerP1> ().Score += 1;
			Destroy (Col.gameObject);
			GameObject.FindWithTag ("OutlineP1-1").GetComponent<OutlineScriptP1> ().OutlineSpeed = Player.GetComponent<PlayerControllerP1> ().Score;
			GameObject.FindWithTag ("OutlineP1-2").GetComponent<OutlineScriptP1> ().OutlineSpeed = Player.GetComponent<PlayerControllerP1> ().Score;
			Invoke ("SpawnBall", 3f);
			StartCoroutine (CamShake.ShakeCam (0.15f, 0.15f));
		}
	}

	void SpawnBall()
	{
		Vector2 SpawnLoc = new Vector2 (0, 0);
		Quaternion SpawnRot = Quaternion.Euler (0, 0, 0);
		GameObject BallInst = Instantiate (Ball, SpawnLoc, SpawnRot);
		BallInst.GetComponent<BallScript> ().IsLeft = true;
	}
}
