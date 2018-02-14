using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Enemy_kill") {
			other.gameObject.transform.parent.gameObject.GetComponent<Killable> ().Kill ();
		}
	}
}
