using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManagerBREAKOUT : MonoBehaviour {

	public GameObject Title;
	public GameObject SinglePlayer;
	public GameObject Exit;
	public GameObject FBButton;
	public GameObject InstaButton;
	public GameObject GPlayButton;
	float StartTime = 0 ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartTime += Time.deltaTime;
		if (StartTime >= 0.5f) {
			Text TitleRenderer = Title.GetComponent<Text> ();
			TitleRenderer.color = GetRandomColor ();
			Image SPRenderer = SinglePlayer.GetComponent<Image> ();
			SPRenderer.color = GetRandomColor ();
			Image ExitRenderer = Exit.GetComponent<Image> ();
			ExitRenderer.color = GetRandomColor ();
			Image FBRenderer = FBButton.GetComponent<Image> ();
			FBRenderer.color = GetRandomColor ();
			Image InstaRenderer = InstaButton.GetComponent<Image> ();
			InstaRenderer.color = GetRandomColor ();
			Image GPlayRenderer = GPlayButton.GetComponent<Image> ();
			GPlayRenderer.color = GetRandomColor ();
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
