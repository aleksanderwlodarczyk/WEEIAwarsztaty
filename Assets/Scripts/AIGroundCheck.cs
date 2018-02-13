using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGroundCheck : MonoBehaviour {


    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            gameObject.transform.parent.gameObject.GetComponent<EnemyMoving>().canGo = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            gameObject.transform.parent.gameObject.GetComponent<EnemyMoving>().canGo = true;
        }
    }
}
