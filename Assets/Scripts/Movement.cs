using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour {
    public float speed = 10f;

	// Use this for initialization
    void Start () {
        
    }

	// Update is called once per frame
	void Update () {
		
	}

	protected void move(Vector2 vector) {
		gameObject.GetComponent<Rigidbody2D>().velocity = vector * speed;
	}
}
