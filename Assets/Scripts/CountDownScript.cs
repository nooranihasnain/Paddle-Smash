using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour {

	private Text CountDown;

	// Use this for initialization
	void Start () {
		CountDown = GetComponent<Text> ();
		StartCoroutine (StartCountDown ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator StartCountDown()
	{
		float TimeLeft = 4f;
		CountDown.text = TimeLeft.ToString ();
		while (TimeLeft > 0) {
			CountDown.text = TimeLeft.ToString ();
			yield return new WaitForSeconds (1f);
			TimeLeft--;
		}
		Destroy (this.gameObject);
	}
}
