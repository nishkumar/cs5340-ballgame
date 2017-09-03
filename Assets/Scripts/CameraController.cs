using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

	// LateUpdate runs after update. 
	// We need to ensure that we move camera after player has moved
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}


/*
 Our goal is to mak eteh camera move along with player. This means that the relative distance 
 between the caera and player object must be kept constant.

*/