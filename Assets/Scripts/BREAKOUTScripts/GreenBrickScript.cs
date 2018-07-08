using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBrickScript : MonoBehaviour {

	public float Health = 20f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D Col)
	{
		if (Col.gameObject.CompareTag ("Ball")) {
			Health -= 20f;
			if (Health <= 0) {
				GetComponent<Animator> ().Play ("Shake");
				gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
				gameObject.GetComponent<SpriteRenderer> ().enabled = false;
				GameObject.FindWithTag ("P1").GetComponent<PlayerControllerP1BREAKOUT> ().Score += 1;
			}
		}
	}	
}
