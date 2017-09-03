using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame before rendering a frame
	void Update () {
		
	}

	// Fixed Update is called before performing physics calculation
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}
}


/*
 To emulate physical behaviour, an object in a game must accelerate correctly 
 and be affected by collisions, gravity and other forces.
 
 Unity’s built-in physics engines provide components that handle the physical simulation. 
 You can create objects that behave passively in a realistic way. 
 
 We use the Rigidbody component for 3D physics. 
*/