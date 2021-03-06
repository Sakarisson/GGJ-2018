﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 8f;
	public PlayerData.Sex sex;

	Vector3 direction;

	public void init(Vector3 _direction, PlayerData.Sex _sex) {
		direction = _direction;
		sex = _sex;
		gameObject.GetComponent<Renderer> ().material.color = sex == PlayerData.Sex.FEMALE ? PlayerData.Pink : PlayerData.LightBlue;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += direction * speed * Time.deltaTime;
	}

	void OnBecameInvisible() {
		Destroy (gameObject);
	}
}
