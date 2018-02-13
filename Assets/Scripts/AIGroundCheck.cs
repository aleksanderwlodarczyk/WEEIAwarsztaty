using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGroundCheck : MonoBehaviour {

	private bool left;

	void Awake(){
		if (gameObject.name.Substring (gameObject.name.Length - 1) == "L") {
			left = true;
		} else {
			left = false;
		}
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
			if (left)
				gameObject.transform.parent.gameObject.GetComponent<EnemyMoving> ().canGoL = false;
			else
				gameObject.transform.parent.gameObject.GetComponent<EnemyMoving> ().canGoR = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
			if (left)
				gameObject.transform.parent.gameObject.GetComponent<EnemyMoving> ().canGoL = true;
			else
				gameObject.transform.parent.gameObject.GetComponent<EnemyMoving> ().canGoR = true;
        }
    }
}
