using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using GoogleMobileAds;


public class NewGame : MonoBehaviour {
	public static bool onePlayer = false;
	public static BannerView banner;

	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		SceneManager.LoadScene ("Game");
		onePlayer = true;
		banner.Hide ();
	}

	void Start(){
		RequestBanner ();
		if(PlayerPrefs.HasKey("EnemySpeed")){
			Enemy.speed = PlayerPrefs.GetFloat("EnemySpeed");
		}
		if(PlayerPrefs.HasKey("BallSpeed")){
			Ball.speed = PlayerPrefs.GetFloat("BallSpeed");
		}
		if(PlayerPrefs.HasKey("FinalScore")){
			Score.end = PlayerPrefs.GetInt("FinalScore");
		}
	}

	public static void RequestBanner(){
		banner = new BannerView ("ca-app-pub-1541045839364233/4668323702", AdSize.Banner, AdPosition.Bottom);
		AdRequest request = new AdRequest.Builder ().Build ();
		banner.LoadAd (request);
		banner.OnAdLoaded += Banner_OnAdLoaded;
	}

	static void Banner_OnAdLoaded (object sender, System.EventArgs e)
	{
		banner.Show();
	}


}
