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
	int initialStartGender = 0;
	int initialGoalGender = 0;
	int initialGoalCollectable = 0;

	int updatedSliderCount = 0;

	public void initialize(){
		updatedSliderCount = 0;
	}

	// Use this for initialization
	void Start () {
		updateProfileData ();
		showSliders ();
		//initialStartGender = playerGenderSlider.value; 
		//playerGenderTitleTextMeshProText.text = "AAA"; 
		//playerGenderDescriptionTextMeshProText.text = "BBBBB";	
	}
	
	// Update is called once per frame
	void Update () {
		
		//if (isProfileChanged ()) {
			
			//update graphics controller
			//updatedSliderCount++;
			showSliders();
			updateProfileData ();
		//}

	}


	void updateProfileData(){
		PlayerData.gender = (int)playerGenderSlider.value;
		PlayerData.goalGender = (int)goalGenderSlider.value;
		PlayerData.goalArmour = (int)goalCollectableSlider.value;
		//ColorManager.FadeFeminine();
		//ColorManager.ScaleRoot
		//ColorManager.FadeMasculine();
	}

	private float bgScaleGenderUndefined = 5f;
	private float bgScaleGenderDefined = 2f;
	private float bgScaleGoalGenderDefined = 1f;
	private bool wasGoalGenderShownPreviously = false;
	int previousGoalCollectableSliderValue = 0;

	void showSliders(){
		playerGenderSlider.gameObject.SetActive(true);
		bool isPlayerGenderDefined = ((int)playerGenderSlider.value)!=1;

		/*
		if (isPlayerGenderDefined && ColorManager.i.lastScaleValue != bgScaleGenderDefined) {
			ColorManager.i.ScaleRoot (bgScaleGenderDefined, 1f);
		} else if (ColorManager.i.lastScaleValue != bgScaleGenderUndefined) {
			ColorManager.i.ScaleRoot (bgScaleGenderUndefined, 1f);
		*/


		if (isPlayerGenderDefined) {

			if (ColorManager.i.lastScaleValue != bgScaleGenderDefined) {
				ColorManager.i.ScaleRoot (bgScaleGenderDefined, 0.6f);
				ColorManager.i.FadeFeminine (false, 0.01f);
				ColorManager.i.FadeMasculine (false, 0.01f);
			}

			goalGenderSlider.gameObject.SetActive(true);

			if (((int)playerGenderSlider.value) != ((int)goalGenderSlider.value)) {				
				goalCollectableSlider.gameObject.SetActive(true);
				if (!wasGoalGenderShownPreviously) {
					goalGenderSlider.value = playerGenderSlider.value;
					if (((int)goalGenderSlider.value) == 0)
						goalCollectableSlider.value = 2;
					else
						goalCollectableSlider.value = 0;

					previousGoalCollectableSliderValue = (int)goalCollectableSlider.value;
				}

				playButton.gameObject.SetActive(true);				
				if (ColorManager.i.lastScaleValue != bgScaleGoalGenderDefined)
					ColorManager.i.ScaleRoot (bgScaleGoalGenderDefined, 0.6f);

				if (previousGoalCollectableSliderValue != (int)goalCollectableSlider.value) {

					if ((int)goalCollectableSlider.value == 0) {
						ColorManager.i.FadeFeminine (true, 0.3f);
						ColorManager.i.FadeMasculine (false, 0.3f);
					} else {
						ColorManager.i.FadeFeminine (false, 0.3f);
						ColorManager.i.FadeMasculine (true, 0.3f);
					}
				}

				wasGoalGenderShownPreviously = true;
				previousGoalCollectableSliderValue = (int)goalCollectableSlider.value;
			} else {
				wasGoalGenderShownPreviously = false;
				goalCollectableSlider.gameObject.SetActive(false);
				playButton.gameObject.SetActive(false);
			}
		} else {

			if (ColorManager.i.lastScaleValue != bgScaleGenderUndefined)
				ColorManager.i.ScaleRoot (bgScaleGenderUndefined, 0.6f);

			wasGoalGenderShownPreviously = false;
			goalGenderSlider.gameObject.SetActive(false);
			goalCollectableSlider.gameObject.SetActive(false);
			playButton.gameObject.SetActive(false);
		}
		/*
		if (updatedSliderCount > 0 && isPlayerGenderDefined)
			goalGenderSlider.gameObject.SetActive(true);
		else
			goalGenderSlider.gameObject.SetActive(false);
		
		if (updatedSliderCount > 1 && isPlayerGenderDefined)
			goalCollectableSlider.gameObject.SetActive(true);
		else
			goalCollectableSlider.gameObject.SetActive(false);
		
		if (updatedSliderCount > 2 && isPlayerGenderDefined)
			playButton.gameObject.SetActive(true);
		else
			playButton.gameObject.SetActive(false);
		*/
		
		/*
		PlayerData.gender = (int)playerGenderSlider.value;
		PlayerData.goalGender = (int)goalGenderSlider.value;
		PlayerData.goalArmour = (int)goalCollectableSlider.value;
		*/
	}

	bool isProfileChanged(){
		if (!PlayerData.gender.Equals ((int)playerGenderSlider.value) || !PlayerData.goalGender.Equals ((int)goalGenderSlider.value) || !PlayerData.goalArmour.Equals ((int)goalCollectableSlider.value)) {			
			return true;
		} else {
			return false;
		}
			
	}
}
