using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;

public class BannerAd : MonoBehaviour
{

	private BannerView bannerView;

	// Use this for initialization
	void Start ()
	{
		string adID = "ca-app-pub-8350504222422488~7708154151";

		MobileAds.Initialize (adID);

		this.showBannerAd ();
	}

	private void showBannerAd ()
	{
		string adUnitId = "ca-app-pub-8350504222422488/6121177109";

		// Create a 320x50 banner at the bottom of the screen.
		//bannerView = new BannerView (adUnitId, AdSize.Banner, AdPosition.Bottom);

		// Create a custom ad size at the bottom of the screen

		AdSize adSize = new AdSize (250, 50);
		BannerView bannerView = new BannerView (adUnitId, adSize, AdPosition.Bottom);

		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ().Build ();

		// Load the banner with the request.
		bannerView.LoadAd (request);

	}

	// Update is called once per frame
	void Update ()
	{
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ().Build ();

		// Load the banner with the request.
		bannerView.LoadAd (request);
	}
}