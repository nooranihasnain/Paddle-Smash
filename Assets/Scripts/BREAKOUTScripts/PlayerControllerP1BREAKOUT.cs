using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP1BREAKOUT : MonoBehaviour {

	public float Speed = 6f;
	private Rigidbody2D PlayerRb;
	public int Score= 0;
	public int Lives = 3;

	// Use this for initialization
	void Start () {
		PlayerRb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		if (Input.touchCount > 2) {
			return;
		} 
		foreach (Touch touch in Input.touches) {
			Vector3 TouchPos = Camera.main.ScreenToWorldPoint (touch.position);
			Vector2 MyPos = transform.position;
			MyPos.x = Mathf.Lerp (MyPos.x, TouchPos.x, Time.deltaTime * Speed);
			MyPos.x = Mathf.Clamp (MyPos.x, -6, 6);
			transform.position = MyPos;
		}
		KeyboardControls (Input.GetAxis ("Horizontal"));
	}

	void KeyboardControls(float AxisVal)
	{
		Vector2 Dir = new Vector2 (AxisVal * Speed, 0);
		PlayerRb.velocity = Dir;
	}
}
