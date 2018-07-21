using System;
using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;

public class AdsController : MonoBehaviour
{

	private RewardBasedVideoAd reward_based;

	void Awake ()
	{
		reward_based = RewardBasedVideoAd.Instance;
		//banner_add = BannerView.Instance;
	}

	// Use this for initialization
	void Start ()
	{
		reward_based.OnAdLoaded += HandleOnAdLoaded;
		reward_based.OnAdFailedToLoad += HandleOnAdFailedToLoad;

		reward_based.OnAdOpening += HandleOnAdOpening;
		reward_based.OnAdStarted += HandleOnAdStarted;
		reward_based.OnAdClosed += HandleOnAdClosed;
		reward_based.OnAdLeavingApplication += HandleOnAdLeavingApplication;
		
		reward_based.OnAdRewarded += HandleOnAdRewarded;


		LoadRewardBasedAd ();
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void ShowTheAdd ()
	{
		if (reward_based.IsLoaded ())
		{
			reward_based.Show ();

			LoadRewardBasedAd ();
		}
		else
		{
			MonoBehaviour.print ("Dude your add's is not loaded yet");
		}
	}

	private void LoadRewardBasedAd ()
	{

		string adUnitId = "ca-app-pub-8350504222422488/7241250290";

		reward_based.LoadAd (new AdRequest.Builder ().Build (), adUnitId);
	}

	public void HandleOnAdLoaded (object sender, EventArgs args)
	{

	}

	public void HandleOnAdFailedToLoad (object sender, AdFailedToLoadEventArgs args)
	{
		// try to reload

		LoadRewardBasedAd();
	}

	public void HandleOnAdOpening (object sender, EventArgs args)
	{
		// pause the action
	}

	public void HandleOnAdStarted (object sender, EventArgs args)
	{
		// mute audio
	}

	public void HandleOnAdClosed (object sender, EventArgs args)
	{
		// crank the party back up
	}

	public void HandleOnAdRewarded (object sender, Reward args)
	{
		//reward the user

		int gem_score = MainMenuController.instance.GetGemScore();

		gem_score++;

		MainMenuController.instance.SetGemScore(gem_score);

		MainMenuController.instance.TextSetGemScore();
	}

	public void HandleOnAdLeavingApplication (object sender, EventArgs args)
	{
		
	}

	public void HandleOnAdCompleted (object sender, EventArgs args)
	{

	}

}