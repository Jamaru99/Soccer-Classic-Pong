using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {

	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		SceneManager.LoadScene ("Settings");
		NewGame.banner.Hide ();
	}
		
}
