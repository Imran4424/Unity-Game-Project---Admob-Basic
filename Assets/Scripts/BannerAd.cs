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
		string adID = "ca-app-pub-8350504222422488/6121177109";

		MobileAds.Initialize (adID);

		this.showBannerAd ();
	}

	private void showBannerAd ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}
}