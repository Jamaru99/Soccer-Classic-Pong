using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeedMinus : MonoBehaviour {

	public TextMesh textSpeed;

	// Update is called once per frame
	void OnMouseDown() {
		Enemy.speed -= 1;
		textSpeed.text = "" + Enemy.speed;
		PlayerPrefs.SetFloat("EnemySpeed", Enemy.speed);
		NewGame.banner.Hide ();
	}
}
