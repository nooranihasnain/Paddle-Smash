﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextAI : MonoBehaviour {

	private Text Player2ScoreText;

	// Use this for initialization
	void Start () {
		Player2ScoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		Player2ScoreText.text = GameObject.FindWithTag ("P2").GetComponent<AIScript> ().Score.ToString ();
	}
}
