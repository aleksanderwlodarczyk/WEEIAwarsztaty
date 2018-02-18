using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	public Transform outputTransform;
	public string typeToTeleport;

	private Transform objectToTeleport;
	
	void Teleporting(){
		objectToTeleport.position = outputTransform.position;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == typeToTeleport) {
			objectToTeleport = other.gameObject.transform;
			Teleporting ();
		}
	}
}
