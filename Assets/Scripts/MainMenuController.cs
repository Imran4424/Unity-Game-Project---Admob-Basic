using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

	public static MainMenuController instance;

	public const string Gem_Score = "Gem Score";

	[SerializeField]
	private Text Gem_Score_Text;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	/*
		The game is started for first time or not to check that
	*/
	

	public void GoToGamePlay()
	{
		SceneManager.LoadScene("GamePlay",LoadSceneMode.Single);
	}
}
