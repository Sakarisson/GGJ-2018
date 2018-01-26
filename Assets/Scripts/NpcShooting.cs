using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcShooting : MonoBehaviour {

	float cooldown = 2f;
	float nextShootAvailable = 0f;

	// Use this for initialization
	void Start() {
		nextShootAvailable = Random.Range(2f, 4f);
	}
	
	// Update is called once per frame
	void Update() {
		if (canShoot())
			shoot();
	}

	bool canShoot() {
		return Time.time >= nextShootAvailable;
	}

	void shoot(){
		Debug.Log("Shots fired!");
		nextShootAvailable = Time.time + cooldown;
	}
}
