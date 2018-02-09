using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

	private GameObject winningScreen;

	void Start () {
		winningScreen = GameObject.Find ("winscreen");
		winningScreen.SetActive (false);
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			winningScreen.SetActive (true);
		}
	}

}
