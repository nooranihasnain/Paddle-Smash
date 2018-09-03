using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

	public bool IsLeft = true;
	public float Speed;
	private Rigidbody2D BallRb;
	public GameObject CountDownTxt;
	private CameraShake CamShake;

	// Use this for initialization
	void Start () {
		BallRb = GetComponent<Rigidbody2D> ();
		Invoke ("SetVeloc", 4f);
		GameObject Txt = Instantiate (CountDownTxt);
		Txt.transform.SetParent (GameObject.FindWithTag ("Canvas").transform, false);
		CamShake = GameObject.FindWithTag ("MainCamera").GetComponent<CameraShake> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D Col)
	{
		//Left Racket
		if (Col.gameObject.CompareTag ("P1")) {
			float Y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Direction = new Vector2 (1, Y).normalized;
			BallRb.velocity = Direction * Speed;
			StartCoroutine (CamShake.ShakeCam (0.05f, 0.05f));
		}
		//Right racket
		if (Col.gameObject.CompareTag ("P2")) {
			float Y = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Direction = new Vector2 (-1, Y).normalized;
			BallRb.velocity = Direction * Speed;
			StartCoroutine (CamShake.ShakeCam (0.05f, 0.05f));
		}
		if (Speed < UIScript.SpeedLimit) {
			Speed += UIScript.SpeedAdd;
		}
	}

	float HitFactor(Vector2 BallPos, Vector2 RacketPos, float racketHeight)
	{
		//-1 means top of rocket
		//0 means middle
		//1 means bottom of racket
		return (BallPos.y - RacketPos.y) / racketHeight;
	}

	void SetVeloc()
	{
		int RandomDirection = Random.Range (1, 3);
		Vector2 LDirection = new Vector2 ();
		Vector2 RDirection = new Vector2 ();
		if (RandomDirection == 1) {
			LDirection = (Vector2.left + Vector2.up).normalized;
			RDirection = (Vector2.right + Vector2.up).normalized;
		}
		else {
			LDirection = (Vector2.left + Vector2.down).normalized;
			RDirection = (Vector2.right + Vector2.down).normalized;
		}
		if (IsLeft) {
			BallRb.velocity = LDirection * Speed;
		} 
		else {
			BallRb.velocity = RDirection * Speed;
		}
	}
}
