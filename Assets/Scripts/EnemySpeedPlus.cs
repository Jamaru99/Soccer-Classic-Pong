using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpeedPlus : MonoBehaviour {

	public TextMesh textSpeed;

	void Awake () {
		textSpeed.text = "" + Enemy.speed;
	}

	void OnMouseDown() {
		Enemy.speed += 1;
		textSpeed.text = "" + Enemy.speed;
		PlayerPrefs.SetFloat("EnemySpeed", Enemy.speed);
		NewGame.banner.Hide ();
	}

	void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
