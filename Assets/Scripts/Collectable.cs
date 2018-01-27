using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	public Sex sex;

	// Use this for initialization
	void Start () {
		sex = Random.value < 0.5f ? Sex.FEMALE : Sex.MALE;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
