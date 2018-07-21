﻿using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;

public class BannerAd : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		showBannerAd ();
	}

	private void showBannerAd ()
	{
		string adID = "ca-app-pub-8350504222422488/6121177109";

		//***For Testing in the Device***
		/* AdRequest request = new AdRequest.Builder ()
			.AddTestDevice (AdRequest.TestDeviceSimulator) // Simulator.
			.AddTestDevice ("2077ef9a63d2b398840261c8221a0c9b") // My test device.
			.Build (); */

		//***For Production When Submit App***
		AdRequest request = new AdRequest.Builder().Build();

		BannerView bannerAd = new BannerView (adID, AdSize.SmartBanner, AdPosition.Bottom);
		bannerAd.LoadAd (request);
	}

	// Update is called once per frame
	void Update ()
	{

	}
}