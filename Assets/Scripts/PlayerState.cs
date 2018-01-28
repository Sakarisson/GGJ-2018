using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.transform.gameObject.name == "Bullet(Clone)") {
			if (coll.transform.gameObject.GetComponent<Bullet> ().sex == PlayerData.Sex.FEMALE) {
				PlayerData.redBullets++;
			} else {
				PlayerData.blueBullets++;
			}
		} else if (coll.transform.gameObject.name == "Collectable(Clone)") {
			if (coll.transform.gameObject.GetComponent<Collectable> ().sex == PlayerData.Sex.FEMALE) {
				PlayerData.redArmor++;
			} else {
				PlayerData.blueArmor++;
			}
		}

		Destroy (coll.transform.gameObject);
	}
}
