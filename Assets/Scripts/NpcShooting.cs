using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcShooting : MonoBehaviour {

	public GameObject bullet;

	GameObject target;

	float cooldown = 2f;
	float nextShootAvailable = 0f;
	float nextTargetAssign = 0f;

	// Use this for initialization
	void Start() {
		nextShootAvailable = Random.Range(2f, 4f);
	}
	
	// Update is called once per frame
	void Update() {
		if (canAssignTarget())
			assignTarget();
		if (canShoot())
			shoot();
	}

	bool canShoot() {
		return Time.time >= nextShootAvailable;
	}

	void shoot(){
		if (target) {
			GameObject shotBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            // shotBullet.GetComponent<Bullet>().init((target.transform.position - transform.position).normalized, Random.value < 0.5f ? PlayerData.Sex.FEMALE : PlayerData.Sex.MALE);
            shotBullet.GetComponent<Bullet>().init((target.transform.position - transform.position).normalized, GetComponent<NpcMovement>().sex);
            nextShootAvailable = Time.time + cooldown;
		}
	}

	bool canAssignTarget() {
		return Time.time >= nextTargetAssign;
	}

	void assignTarget() {
		Collider[] targetColliders = Physics.OverlapSphere(transform.position, 5f);
		if (targetColliders.Length > 1) {
			target = randomizeTarget(targetColliders);
			nextTargetAssign = Time.time + 5f;
		} else {
			target = null;
			nextTargetAssign = Time.time + 1f;
		}
	}

	GameObject randomizeTarget(Collider[] targetColliders) {
		int randomIndex = Mathf.FloorToInt(Random.Range (0f, targetColliders.Length - 0.000001f));
		if (targetColliders[randomIndex].transform.gameObject != gameObject.transform.Find("Cube").transform.gameObject) {
			return targetColliders[randomIndex].transform.gameObject;
		} else {
			return randomizeTarget(targetColliders);
		}
	}
}
