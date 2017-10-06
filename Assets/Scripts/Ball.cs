using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Ball Movement Speed
	public float speed = 100.0f;

	// Use this for initialization
	void Start () {
		// Vector2.up is Shorthand for writing Vector2(0, 1).
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

	}

	// Update is called once per frame
	void Update () {

	}

	// returns the balls x coordinate in relation to the racket
	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth){

		// ascii art:
		// 1  -0.5  0  0.5   1  <- x value
		// ===================  <- racket
		//
		return(ballPos.x - racketPos.x)/ racketWidth;


	}

	// This function is called whenever the ball
	// collides with something
	void OnCollisionEnter2D(Collision2D col){
		// check to see if racket hit.
		if (col.gameObject.name == "racket"){
			// calculate hit factor!
			float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

			// calculate direction, set length to 1
			// Y should always be 1 because we want the
			// ball to move upwards not down.

			Vector2 dir = new Vector2(x, 1).normalized;

			// set new velocity with dir * speed.velocity
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}


	}
}
