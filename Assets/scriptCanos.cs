﻿using UnityEngine;
using System.Collections;

public class scriptCanos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GetComponent<Rigidbody2D>().velocity = new Vector2(-10,0);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -10)
		{
			Destroy (gameObject);
	 	}
	}
}
