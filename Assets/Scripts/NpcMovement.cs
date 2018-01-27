using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : Movement {

	float tarX = 0f;
	float tarY = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (destinationReached())
			setNewTarget();
		move((new Vector2(tarX, tarY) - new Vector2(transform.position.x, transform.position.y)).normalized);
	}

	void setNewTarget() {
		tarX = Random.Range(-5f, 5f);
		tarY = Random.Range(-5f, 5f);
	}

	bool destinationReached() {
		return System.Math.Abs(tarX - transform.position.x) < 0.5f && System.Math.Abs(tarY - transform.position.y) < 0.5f;
	}
}
