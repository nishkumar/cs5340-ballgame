using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCapsule : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	// Make the object spin
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}


/*

// Local Axis
// Rotate the object around its local X axis at 1 degree per second
// transform.Rotate(Time.deltaTime, 0, 0);

// Rotate the object around its local X axis at 1 degree per second
// transform.Rotate(Vector3.right, Time.deltaTime);

// Rotate around the World's Y axis
// transform.Rotate(0, Time.deltaTime, 0, Space.World);
// transform.Rotate(Vector3.up, Time.deltaTime, Space.World);

*/