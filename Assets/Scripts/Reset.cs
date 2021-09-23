using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	public TextMesh enemy;
	public TextMesh ball;
	public TextMesh maxScore;

	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		Ball.speed = 17;
		Enemy.speed = 8;
		Score.end = 5;
		ball.text = "" + Ball.speed;
		enemy.text = "" + Enemy.speed;
		maxScore.text = "" + Score.end;
		PlayerPrefs.SetFloat("EnemySpeed", Enemy.speed);
		PlayerPrefs.SetFloat("BallSpeed", Ball.speed);
		PlayerPrefs.SetInt("FinalScore", Score.end);
		transform.localScale /= 0.8f;
	}
}
