using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	public GameObject Pause;
	public GameObject PauseMenu;
	public Animator PauseMenuAnim;
	public Animator SinglePlayerButtAnim;
	public static bool IsMultiplayer = false;
	public GameObject EasyButton;
	public GameObject MediumButton;
	public GameObject Ball;
	public static float SpeedAdd;
	public static float SpeedLimit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenInstaPage()
	{
		Application.OpenURL ("www.instagram.com/_zephyrgames_/");
	}

	public void OpenFBPage()
	{
		Application.OpenURL ("www.facebook.com/ZephyrGamesOfficial");
	}

	public void OpenGooglePlayPage()
	{
		
	}

	public void LoadLevel(string Levelname)
	{
		Initiate.Fade (Levelname, Color.black, 2f);
	}

	public void PauseGame()
	{
		Time.timeScale = 0;
		Pause.SetActive (false);
		PauseMenu.SetActive (true);
	}

	public void ResumeGame()
	{
		Time.timeScale = 1;
		PauseMenuAnim.Play ("GoBack");
		Invoke ("DeactivateMenu", 0.2f);
		Pause.SetActive (true);
	}

	void DeactivateMenu()
	{
		PauseMenu.SetActive (false);
	}

	public void MoveSinglePlayer()
	{
		SinglePlayerButtAnim.Play ("Move");
		EasyButton.SetActive (true);
		MediumButton.SetActive (true);
	}

	public void QuitLevel()
	{
		Time.timeScale = 1;
		PauseMenuAnim.Play ("GoBack");
		Initiate.Fade ("Main Menu", Color.black, 3f);
	}

	public void StartMultiplayer()
	{
		SpeedAdd = 1f;
		SpeedLimit = 13f;
		LoadLevel ("PlaygroundMultiplayer");
	}

	public void StartEasyLevel()
	{
		SpeedAdd = 0.5f;
		SpeedLimit = 10f;
		LoadLevel ("PlaygroundSinglePlayer");
	}

	public void StartMediumLevel()
	{
		SpeedAdd = 1.5f;
		SpeedLimit = 12f;
		LoadLevel ("PlaygroundSinglePlayer");
	}

	public void RetryLevel()
	{
		if (IsMultiplayer) {
			LoadLevel ("PlaygroundMultiplayer");
			IsMultiplayer = false;
		} 
		else {
			LoadLevel ("PlaygroundSinglePlayer");
			IsMultiplayer = false;
		}
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
