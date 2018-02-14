using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class KeyboardMovement : MonoBehaviour {

	public float speed = 10f;
	public float jumpForce = 50f;
	public float maxSpeed = 7f;

	private bool canJump;
	private Rigidbody2D rb2d;
	private float horizontal;
	private float realSpeed;
	private GameOver gOver;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		realSpeed = speed;
		canJump = true;
		gOver = GameObject.Find ("GameOver").GetComponent<GameOver> ();
	}
	

	void Update () {
		if (gOver.playing) {
			horizontal = Input.GetAxis ("Horizontal");
		} else {
			horizontal = 0;
		}

		rb2d.AddForce (Vector2.right * horizontal * realSpeed);

		if ((rb2d.velocity.x * horizontal) < 0)
			realSpeed = 10 * speed;
		else
			realSpeed = speed;

		if ((Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) && canJump) {
			rb2d.AddForce (Vector2.up * jumpForce * 3);
			canJump = false;
		}

		if (!canJump && rb2d.velocity.y > 0 && rb2d.gravityScale <= 3f) {
			rb2d.gravityScale += 0.07f;
		}

		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
			realSpeed = 0;
		else
			realSpeed = speed;
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			canJump = true;
			rb2d.gravityScale = 1;
		}
		
	}
}
