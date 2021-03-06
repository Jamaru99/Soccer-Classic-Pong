using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpeedMinus : MonoBehaviour {

	public TextMesh textSpeed;

	// Update is called once per frame
	void OnMouseDown() {
		if (Ball.speed > 1) {
			Ball.speed -= 1;
			textSpeed.text = "" + Ball.speed;
			PlayerPrefs.SetFloat("BallSpeed", Ball.speed);
		}
		NewGame.banner.Hide ();
	}

	void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
