using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	private GameOver gOver;

	void Start(){
		gOver = GameObject.Find ("GameOver").GetComponent<GameOver> ();
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			coll.gameObject.GetComponent<Killable> ().Kill ();
			gOver.Defeat ();
		}
		
	}
}
