using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Sex {
	FEMALE,
	MALE,
};

public class PlayerState : MonoBehaviour {
    Sex initialState;
    // Symbolizes gender identity
    float tribe; // 0 - 1 where 0 is totally feminine and 1 is totally masculine
    float armor; // 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.transform.gameObject.name == "Bullet(Clone)") {
			if (coll.transform.gameObject.GetComponent<Bullet> ().sex == Sex.FEMALE) {
				PlayerData.redBullets++;
			} else {
				PlayerData.blueBullets++;
			}
		} else if (coll.transform.gameObject.name == "Collectable(Clone)") {
			if (coll.transform.gameObject.GetComponent<Collectable> ().sex == Sex.FEMALE) {
				PlayerData.redArmor++;
			} else {
				PlayerData.blueArmor++;
			}
		}

		Destroy (coll.transform.gameObject);
	}
}
