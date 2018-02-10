using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

	private GameObject winningScreen;
	private GameOver gOver;

	void Start () {
		winningScreen = GameObject.Find ("winscreen");
		gOver = GameObject.Find ("GameOver").GetComponent<GameOver> ();
		winningScreen.SetActive (false);
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			winningScreen.SetActive (true);
			gOver.playing = false;

		}
	}

}
