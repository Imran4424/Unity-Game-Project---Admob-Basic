using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

	[SerializeField]
	private Text GemScoreText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	// changing scene

	public void BackToMainMenu()
	{
		SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
	}
}
