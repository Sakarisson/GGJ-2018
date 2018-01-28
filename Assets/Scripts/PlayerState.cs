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
			    GameObject go = Instantiate(Resources.Load<GameObject>("PINK_BOOM"),coll.transform.position, coll.transform.rotation);
			    Destroy(go, 1f);
			}
            else {
				PlayerData.blueBullets++;
			    GameObject go = Instantiate(Resources.Load<GameObject>("BLUE_BOOM"),coll.transform.position, coll.transform.rotation);
			    Destroy(go, 1f);
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
