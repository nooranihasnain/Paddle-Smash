using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

	private static AudioScript instance = null;


	void Awake()
	{
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
		} 
		else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static AudioScript GetInstance
	{
		get {
			return instance;
		}
	}
}
