using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Sex {
    MALE,
    FEMALE,
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

    public void PlayerWasHit(Sex type) {
        
    }
}
