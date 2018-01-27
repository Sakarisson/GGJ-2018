using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour {

	public float speed = 5f;

	float destinationX = 0f;
	float destinationY = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (destinationReached())
			setNewDestination();
		gameObject.GetComponent<Rigidbody2D>().velocity = (new Vector2(destinationX, destinationY) - new Vector2(transform.position.x, transform.position.y)).normalized * speed;
	}

	void setNewDestination() {
		destinationX = Random.Range(-5f, 5f);
		destinationY = Random.Range(-5f, 5f);
	}

	bool destinationReached() {
		return System.Math.Abs(destinationX - transform.position.x) < 0.5f && System.Math.Abs(destinationY - transform.position.y) < 0.5f;
	}
}
