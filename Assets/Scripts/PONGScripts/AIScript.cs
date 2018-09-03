using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour {

	public float Speed;
	public int Score = 0;
	private SpriteRenderer RacketSprite;
	private GameObject Ball;
	float Step ;
	// Use this for initialization
	void Start () {
		RacketSprite = GetComponent<SpriteRenderer> ();
		Speed = UIScript.AISpeed;
	}

	// Update is called once per frame
	void Update () {
		Ball = GameObject.FindWithTag ("Ball");
		if (Ball == null) {
			
		} 
		else {
			Step = Speed * Time.deltaTime;
			Vector2 Pos = new Vector2 (transform.position.x, Mathf.Lerp (transform.position.y, Ball.transform.position.y, Step));
			transform.position = Pos;
		}
		if (Score >= 6) {
			Speed = 3f;
		}
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
