﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
	}
}
