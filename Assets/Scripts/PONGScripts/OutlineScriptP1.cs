using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineScriptP1 : MonoBehaviour {

	private Rigidbody2D OutlineRb;
	public float OutlineSpeed;
	// Use this for initialization
	void Start () {
		OutlineRb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= -19) {
			Vector2 Location = new Vector2 (17f, transform.position.y);
			transform.position = Location;
		}
		OutlineRb.velocity = new Vector2 (-OutlineSpeed, 0);
	}
}
