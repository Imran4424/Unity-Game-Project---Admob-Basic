using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

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

	void IsTheGameStartedForTheFirstTime ()
	{
		if (!PlayerPrefs.HasKey ("IsTheGameStartedForTheFirstTime"))
		{
			PlayerPrefs.SetInt(Gem_Score,10);	

			PlayerPrefs.SetInt ("IsTheGameStartedForTheFirstTime", 0);
		}
	}

	// setting and getting gem score

	public void SetGemScore(int score)
	{
		PlayerPrefs.SetInt(Gem_Score,score);
	}

	public void GoToGamePlay ()
	{
		SceneManager.LoadScene ("GamePlay", LoadSceneMode.Single);
	}
}