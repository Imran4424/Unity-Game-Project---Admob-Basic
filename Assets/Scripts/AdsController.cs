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

		// Called when an ad request has successfully loaded.
		reward_based.OnAdLoaded += HandleRewardBasedVideoLoaded;

		// Called when an ad request failed to load.
		reward_based.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;

		// Called when an ad is shown.
		reward_based.OnAdOpening += HandleRewardBasedVideoOpened;

		// Called when the ad starts to play.
		reward_based.OnAdStarted += HandleRewardBasedVideoStarted;

		// Called when the user should be rewarded for watching a video.
		reward_based.OnAdRewarded += HandleRewardBasedVideoRewarded;

		// Called when the ad is closed.
		reward_based.OnAdClosed += HandleRewardBasedVideoClosed;

		// Called when the ad click caused the user to leave the application.
		reward_based.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;

		this.RequestRewardBasedVideo ();
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
		}

	}

	private void RequestRewardBasedVideo ()
	{
		string adUnitId = "ca-app-pub-8350504222422488/7241250290";

		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ().Build ();
		// Load the rewarded video ad with the request.
		this.reward_based.LoadAd (request, adUnitId);
	}

	public void HandleRewardBasedVideoLoaded (object sender, EventArgs args)
	{
		MonoBehaviour.print ("HandleRewardBasedVideoLoaded event received");
	}

	public void HandleRewardBasedVideoFailedToLoad (object sender, AdFailedToLoadEventArgs args)
	{
		MonoBehaviour.print (
			"HandleRewardBasedVideoFailedToLoad event received with message: " +
			args.Message);
		this.RequestRewardBasedVideo ();
	}

	public void HandleRewardBasedVideoOpened (object sender, EventArgs args)
	{
		MonoBehaviour.print ("HandleRewardBasedVideoOpened event received");
	}

	public void HandleRewardBasedVideoStarted (object sender, EventArgs args)
	{
		MonoBehaviour.print ("HandleRewardBasedVideoStarted event received");
	}

	public void HandleRewardBasedVideoClosed (object sender, EventArgs args)
	{
		MonoBehaviour.print ("HandleRewardBasedVideoClosed event received");

		this.RequestRewardBasedVideo ();

	}

	public void HandleRewardBasedVideoRewarded (object sender, Reward args)
	{
		/* string type = args.Type;
		double amount = args.Amount;
		MonoBehaviour.print (
			"HandleRewardBasedVideoRewarded event received for " +
			amount.ToString () + " " + type); */

		//reward the user

		int gem_score = MainMenuController.instance.GetGemScore ();

		gem_score++;

		MainMenuController.instance.SetGemScore (gem_score);

		MainMenuController.instance.TextSetGemScore ();
	}

	public void HandleRewardBasedVideoLeftApplication (object sender, EventArgs args)
	{
		MonoBehaviour.print ("HandleRewardBasedVideoLeftApplication event received");
	}

}