using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	public PlayerData.Sex sex;

	float destroyAt;

	// Use this for initialization
	void Start () {
		sex = Random.value < 0.5f ? PlayerData.Sex.FEMALE : PlayerData.Sex.MALE;
		destroyAt = Time.time + 10f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= destroyAt)
			Destroy(gameObject);
	}
}
