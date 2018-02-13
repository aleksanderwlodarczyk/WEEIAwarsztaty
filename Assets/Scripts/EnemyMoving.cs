using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour {

    public bool canGo;
    public float speed = 10f;

    private GameOver gOver;
    private Rigidbody2D rb2d;

	void Start () {
        canGo = true;
        gOver = GameObject.Find("GameOver").GetComponent<GameOver>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        if(canGo && gOver.playing)
        {
            rb2d.AddForce(Vector2.left * speed * Mathf.Sin(Time.time*3));
        }
    }
	

}
