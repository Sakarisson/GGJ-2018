﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour {
    private Camera mainCamera;
    public PlayerData.Sex sex;
    public Material fem;
    public Material mal;
	public float speed = 5f;
    public Sprite[] genderSymbols;

	float destinationX = 0f;
	float destinationY = 0f;

	// Use this for initialization
    void Start () {
        mainCamera = Camera.main;
        if (Random.value < .5f) {
            sex = PlayerData.Sex.FEMALE;
        } else {
            sex = PlayerData.Sex.MALE;
        }
        SetGenderDetails();
	}

    private void SetGenderDetails() {
        // Set symbol
        Material mat = sex == PlayerData.Sex.MALE ? mal : fem;
        gameObject.GetComponentsInChildren<Renderer>()[1].material = mat;
        // Set color
        Color color;
        color = sex == PlayerData.Sex.MALE ? PlayerData.LightBlue : PlayerData.Pink;
        gameObject.GetComponentsInChildren<Renderer>()[1].material.color = color; // DEAD BIRD DO NOT EAT
    }
	
	// Update is called once per frame
	void Update () {
		if (destinationReached())
			setNewDestination();
		gameObject.GetComponent<Rigidbody2D>().velocity = (new Vector2(destinationX, destinationY) - new Vector2(transform.position.x, transform.position.y)).normalized * speed;
	}

    private void FixedUpdate() {
        transform.Rotate(new Vector3(1, 1, 1));
    }

    void setNewDestination() {
		destinationX = Random.Range(-18f, 18f);
		destinationY = Random.Range(-8f, 8f);
	}

	bool destinationReached() {
		return System.Math.Abs(destinationX - transform.position.x) < 0.5f && System.Math.Abs(destinationY - transform.position.y) < 0.5f;
	}
}
