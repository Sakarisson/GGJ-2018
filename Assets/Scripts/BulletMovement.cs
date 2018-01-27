using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	public float speed = 8f;
	Vector3 direction;

	public void setDirection(Vector3 _direction) {
		direction = _direction;
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
