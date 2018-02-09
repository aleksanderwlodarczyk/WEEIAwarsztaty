using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour {

	public int scoreToAdd = 1;

	void FixedUpdate(){
		transform.Translate (Vector2.up * 0.008f * Mathf.Sin (Time.time*5));
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			GameObject.Find ("Points").GetComponent<PointsHandler> ().AddScore (scoreToAdd);
			Destroy (gameObject);
		}
	}
}
