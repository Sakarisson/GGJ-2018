using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileController : MonoBehaviour {

	public Slider playerGenderSlider;
	public Slider goalGenderSlider;
	public Slider goalCollectableSlider;

	public Button playButton;

	public TextMeshProUGUI playerGenderTitleTextMeshProText;
	public TextMeshProUGUI playerGenderDescriptionTextMeshProText;

	/// <summary>
	/// The current gender state. Values from 0 to 100.
	/// 0 = masculine, 100 = feminine
	/// </summary>
	//int initialStartGender = 0;
	//public static int initialGoalGender = 0;
	//public static int initialGoalCollectable = 0;

	int updatedSliderCount = 0;

	public void initialize(){
		updatedSliderCount = 0;
	}

	// Use this for initialization
	void Start () {
		//initialStartGender = playerGenderSlider.value; 
		//playerGenderTitleTextMeshProText.text = "AAA"; 
		//playerGenderDescriptionTextMeshProText.text = "BBBBB";	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (isProfileChanged ()) {
			updateProfileData ();
			//update graphics controller
			updatedSliderCount++;
			showSliders();
		}
		*/
	}


	void updateProfileData(){
		PlayerData.gender = (int)playerGenderSlider.value;
		PlayerData.goalGender = (int)goalGenderSlider.value;
		PlayerData.goalArmour = (int)goalCollectableSlider.value;
		//ColorManager.FadeFeminine();
		//ColorManager.ScaleRoot
		//ColorManager.FadeMasculine();
	}

	void showSliders(){
		playerGenderSlider.gameObject.SetActive(true);
		if (updatedSliderCount > 0)
			goalGenderSlider.gameObject.SetActive(true);
		if (updatedSliderCount > 1)
			goalCollectableSlider.gameObject.SetActive(true);
		if (updatedSliderCount > 2)
			playButton.gameObject.SetActive(true);

		PlayerData.gender = (int)playerGenderSlider.value;
		PlayerData.goalGender = (int)goalGenderSlider.value;
		PlayerData.goalArmour = (int)goalCollectableSlider.value;
	}

	bool isProfileChanged(){
		if (false && !PlayerData.gender.Equals ((int)playerGenderSlider.value) || !PlayerData.goalGender.Equals ((int)goalGenderSlider.value) || !PlayerData.goalArmour.Equals ((int)goalCollectableSlider.value)) {			
			return true;
		} else {
			return false;
		}
			
	}
}
