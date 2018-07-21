using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public static MainMenuController instance;

	public const string Gem_Score = "Gem Score";

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void GoToGamePlay()
	{
		SceneManager.LoadScene("GamePlay",LoadSceneMode.Single);
	}
}
