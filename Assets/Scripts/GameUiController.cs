using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUiController : MonoBehaviour {

	private int previousGenderPoints = 0;
	private int previousSexualOrientationPoints = 0;
	public Slider playerGenderStatusSlider;
	public Slider playerSexualOrientationStatusSlider;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int genderPoints = 0;
		int orientationPoints = 0;		
		genderPoints = (int)playerGenderStatusSlider.value;
		orientationPoints = (int)playerSexualOrientationStatusSlider.value;

		playerGenderStatusSlider.value = genderPoints;
		playerSexualOrientationStatusSlider.value = orientationPoints;
	}
}
