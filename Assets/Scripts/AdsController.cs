using System;
using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;

public class AdsController : MonoBehaviour
{

	private RewardBasedVideoAd reward_based;

	// Use this for initialization
	void Start ()
	{
		string appId = "ca-app-pub-8350504222422488~7708154151";

		// Initialize the Google Mobile Ads SDK.
		MobileAds.Initialize (appId);

		// Get singleton reward based video ad reference.
		this.reward_based = RewardBasedVideoAd.Instance;

		this.RequestRewardBasedVideo ();

		reward_based.OnAdLoaded += HandleOnAdLoaded;
		reward_based.OnAdFailedToLoad += HandleOnAdFailedToLoad;

		reward_based.OnAdOpening += HandleOnAdOpening;
		reward_based.OnAdStarted += HandleOnAdStarted;
		reward_based.OnAdClosed += HandleOnAdClosed;
		reward_based.OnAdLeavingApplication += HandleOnAdLeavingApplication;

		reward_based.OnAdRewarded += HandleOnAdRewarded;

	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void ShowTheAdd ()
	{
		
	}

	private void RequestRewardBasedVideo ()
	{
		string adUnitId = "ca-app-pub-8350504222422488/7241250290";

		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ().Build ();
		// Load the rewarded video ad with the request.
		this.reward_based.LoadAd (request, adUnitId);
	}

	

	public void HandleOnAdLoaded (object sender, EventArgs args)
	{

	}

	public void HandleOnAdFailedToLoad (object sender, AdFailedToLoadEventArgs args)
	{
		// try to reload

		LoadRewardBasedAd ();
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

		int gem_score = MainMenuController.instance.GetGemScore ();

		gem_score++;

		MainMenuController.instance.SetGemScore (gem_score);

		MainMenuController.instance.TextSetGemScore ();
	}

	public void HandleOnAdLeavingApplication (object sender, EventArgs args)
	{

	}

	public void HandleOnAdCompleted (object sender, EventArgs args)
	{

	}

}