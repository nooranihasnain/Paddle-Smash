using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP2PONG : MonoBehaviour {

	public float Speed =6f;
	private Rigidbody2D RacketRb;
	public int Score = 0;
	private SpriteRenderer RacketSprite;
	// Use this for initialization
	void Start () {
		RacketRb = GetComponent<Rigidbody2D> ();
		RacketSprite = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.touchCount > 2) {
			return;
		}

		foreach (Touch touch in Input.touches) {
			Vector3 TouchPos = Camera.main.ScreenToWorldPoint (touch.position);
			Vector2 MyPos = transform.position;
			if (Mathf.Abs (TouchPos.x - MyPos.x) <= 2) {
				MyPos.y = Mathf.Lerp (MyPos.y, TouchPos.y, Time.deltaTime * Speed);
				MyPos.y = Mathf.Clamp (MyPos.y, -4, 4);
				transform.position = MyPos;
			}
		}
		KeyboardControls (Input.GetAxis ("Vertical"));
	}

	void KeyboardControls(float AxisVal)
	{
		Vector2 Dir = new Vector2 (0, AxisVal * Speed);
		RacketRb.velocity = Dir;
	}

	void OnCollisionEnter2D(Collision2D Col)
	{
		if (Col.gameObject.CompareTag ("Ball")) {
			Color Racketcol = new Color (1,1,1,1);
			RacketSprite.color = Racketcol;
		}
	}

	void OnCollisionExit2D()
	{
		Color Racketcol = new Color (1,1,1,0.9411f);
		RacketSprite.color = Racketcol;
	}
}
