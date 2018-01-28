using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ContextChanger))]
public class GameController : MonoBehaviour {
    ContextChanger ctx;

	// Use this for initialization
	void Start () {
        ctx = gameObject.GetComponent<ContextChanger>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
