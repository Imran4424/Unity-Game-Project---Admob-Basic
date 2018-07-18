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
	}

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	private void LoadRewardBasedAd()
	{
		#if UNINY_EDITOR
			string adUnitId = "unused";
		#elif UNITY_ANDROID = 
	}
}