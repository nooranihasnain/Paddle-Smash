using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScriptBREAKOUT : MonoBehaviour {

	public float Speed =6f;
	private Rigidbody2D BallRb;
	private CameraShake CamShake;
	private bool SpeedSlow= false;

	// Use this for initialization
	void Start () {
		BallRb = GetComponent<Rigidbody2D> ();
		Invoke ("SetVeloc", 1f);
		CamShake = GameObject.FindWithTag ("MainCamera").GetComponent<CameraShake> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetVeloc()
	{
		BallRb.velocity = Vector2.up * Speed;
	}

	float HitFactor(Vector2 BallPos, Vector2 RacketPos, float RacketHeight)
	{
		return (BallPos.x - RacketPos.x) / RacketHeight;
	}

	void OnCollisionEnter2D(Collision2D Col)
	{
		if (Col.gameObject.CompareTag ("P1")) {
			float X = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.x);
			Vector2 Direction = new Vector2 (-X, 1).normalized;
			BallRb.velocity = Direction * Speed;
			if (SpeedSlow) {
				Speed += Random.Range(0.5f,4f);
				SpeedSlow = false;
			} 
			else if (!SpeedSlow) {
				Speed -= Random.Range(0.5f,2f);
				SpeedSlow = true;
			}
			StartCoroutine (CamShake.ShakeCam (0.15f, 0.15f));
		}
		if (Col.gameObject.CompareTag ("Brick")) {
			float X = HitFactor (transform.position, Col.transform.position, Col.collider.bounds.size.x);
			Vector2 Direction = new Vector2 (X, -1).normalized;
			BallRb.velocity = Direction * Speed;
		}
	}
}
