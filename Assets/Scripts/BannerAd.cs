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

		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView (adUnitId, AdSize.Banner, AdPosition.Top);

	}

	// Update is called once per frame
	void Update ()
	{

	}
}