using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	private GameObject loseScreen;
	public bool playing;

	void Start () {
		loseScreen = GameObject.Find ("losescreen");
		loseScreen.SetActive (false);

		playing = true;
	}

	public void Defeat(){
		loseScreen.SetActive (true);
		playing = false;
	}

}
