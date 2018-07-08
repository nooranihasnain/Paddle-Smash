using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour {
	public Text Title;
	public GameObject SinglePlayer;
	public GameObject Multiplayer;
	public GameObject Quit;
	public GameObject Easy;
	public GameObject Medium;
	public GameObject LikeButton;
	public GameObject InstaButton;
	public GameObject GooglePlayButton;

	float StartTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartTime += Time.deltaTime;
		if (StartTime >= 0.5f) {
			if (Title.IsActive ()) {
				Title.color = GetRandomColor ();
			}
			Image SPRenderer = SinglePlayer.GetComponent<Image> ();
			if (SinglePlayer.activeInHierarchy) {
				SPRenderer.color = GetRandomColor ();
			}
			Image MPRenderer = Multiplayer.GetComponent<Image> ();
			if (Multiplayer.activeInHierarchy) {
				MPRenderer.color = GetRandomColor ();
			}
			Image QuitRenderer = Quit.GetComponent<Image> ();
			if (Quit.activeInHierarchy) {
				QuitRenderer.color = GetRandomColor ();
			}
			Image EasyRenderer = Easy.GetComponent<Image> ();
			if (Easy.activeInHierarchy) {
				EasyRenderer.color = GetRandomColor ();
			}
			Image MediumRenderer = Medium.GetComponent<Image> ();
			if (Medium.activeInHierarchy) {
				MediumRenderer.color = GetRandomColor ();
			}
			Image LikeButtonRenderer = LikeButton.GetComponent<Image> ();
			if (LikeButton.activeInHierarchy) {
				LikeButtonRenderer.color = GetRandomColor ();
			}
			Image InstaButtonRenderer = InstaButton.GetComponent<Image> ();
			if (InstaButton.activeInHierarchy) {
				InstaButtonRenderer.color = GetRandomColor ();
			}
			Image GPlayRenderer = GooglePlayButton.GetComponent<Image> ();
			if (GooglePlayButton.activeInHierarchy) {
				GPlayRenderer.color = GetRandomColor ();
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
