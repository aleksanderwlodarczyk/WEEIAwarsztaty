using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour {

    public bool canGoL;
	public bool canGoR;
    public float speed = 10f;

    private GameOver gOver;
    private Rigidbody2D rb2d;

	void Start () {
        canGoL = true;
		canGoR = true;
        gOver = GameObject.Find("GameOver").GetComponent<GameOver>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();



    }


    void FixedUpdate()
    {
        if(gOver.playing)
        {
			float sin = Mathf.Sin (Time.time * 2);
			if (sin <= 0 && canGoL) {
				rb2d.AddForce (Vector2.right * speed * sin);
			} else if (!canGoL) {
				Stop ();
			}

			if (sin > 0 && canGoR) {
				rb2d.AddForce (Vector2.right * speed * sin);
			} else if (!canGoR) {
				Stop ();
			}


        }
    }


	void Stop(){
		rb2d.AddForce (rb2d.velocity * -10f);
	}

}
