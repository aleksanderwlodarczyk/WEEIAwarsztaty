using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	[Header("Dokąd przenieść")]
	public Transform outputTransform;
	[Header("Kogo przenieść")]
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
