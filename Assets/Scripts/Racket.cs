using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

	public float speed = 150;
	private float h;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){

		// Get Horizontal Input
		float h = Input.GetAxisRaw("Horizontal");

		// Set Velocity (Movement direction * speed)
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;

	}
}
