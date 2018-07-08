using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManagerModeMenu : MonoBehaviour {

	public GameObject Title;
	float StartTime =0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartTime += Time.deltaTime;
		if (StartTime >= 0.5f) {
			Text TitleRenderer = Title.GetComponent<Text> ();
			if (Title.activeInHierarchy) {
				TitleRenderer.color = GetRandomColor ();
			}
			StartTime = 0;
		}
	}

	Color GetRandomColor()
	{
		int Choice = Random.Range (1, 4);
		if (Choice == 1) {
			return Color.red;
		} else if (Choice == 2) {
			return Color.green;
		} else if (Choice == 3) {
			return Color.blue;
		}
		return Color.white;
	}
}
