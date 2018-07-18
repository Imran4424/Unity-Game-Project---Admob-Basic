﻿using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;
using System;

public class AdsController : MonoBehaviour
{

	private RewardBasedVideoAd reward_based;

	void Awake ()
	{
		reward_based = RewardBasedVideoAd.Instance;
	}

	// Use this for initialization
	void Start ()
	{
		LoadRewardBasedAd ();
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void ShowTheadd ()
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
#if UNINY_EDITOR
		string adUnitId = "unused";
#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-8350504222422488/7241250290";
#else
		string adUnitId = "unexpected_platform";
#endif

		reward_based.LoadAd (new AdRequest.Builder ().Build (), adUnitId);
	}

	public event EventHandler<EventArgs> OnAdLoaded;

	public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad;

	public event EventHandler<EventArgs> OnAdOpening;

	public event EventHandler<EventArgs> OnAdStarted;

	public event EventHandler<EventArgs> OnAdClosed;

	public event EventHandler<Reward> OnAdRewarded;

	public event EventHandler<EventArgs> OnAdLeavingApplication;

	public event EventHandler<EventArgs> OnAdCompleted;

}