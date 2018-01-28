using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUiController : MonoBehaviour {

	public TextMeshProUGUI storyTitleTextMeshProText;
	public TextMeshProUGUI storyDescriptionTextMeshProText;
	public TextMeshProUGUI scoreGoalTextMeshProText;
	public TextMeshProUGUI scoreArmorTextMeshProText;


	public Sprite feminineTexture;
	public Sprite maskulineTexture;
	public Sprite transTexture;
	public Sprite feminineArmorTexture;
	public Sprite maskulineArmorTexture;
	public Sprite transArmorTexture;

	public Image genderStartTexture;
	public Image genderGoalTexture;
	public Image orientationStartTexture;
	public Image orientationGoalTexture;

	private int previousGenderPoints = 0;
	private int previousSexualOrientationPoints = 0;
	public Slider playerGenderStatusSlider;
	public Slider playerSexualOrientationStatusSlider;
    public GameObject playerPrefab;

	private Sprite getIconSprite(int genderType){
		Sprite s = maskulineTexture;
		if (genderType == 0)
			s = feminineTexture;
		else if (genderType == 1)
			s = transTexture;

		return s;
	}

	private Sprite getArmorIconSprite(int genderType){
		Sprite s = maskulineArmorTexture;
		if (genderType == 0)
			s = feminineArmorTexture;
		else if (genderType == 1)
			s = transArmorTexture;

		return s;
	}

	// Use this for initialization
	void Start () {
        Spawn();
	}

	public void initializeUi(){
		genderStartTexture.sprite = getIconSprite(PlayerData.startGender);
		genderGoalTexture.sprite = getIconSprite(PlayerData.goalGender);
		orientationStartTexture.sprite = getArmorIconSprite(PlayerData.startArmour);
		orientationGoalTexture.sprite = getArmorIconSprite(PlayerData.goalArmour);
	}
	
	// Update is called once per frame
	void Update () {
		int genderPoints = 0;
		int orientationPoints = 0;		
		genderPoints = (int)playerGenderStatusSlider.value;
		orientationPoints = (int)playerSexualOrientationStatusSlider.value;

		playerGenderStatusSlider.value = genderPoints;
		playerSexualOrientationStatusSlider.value = orientationPoints;

		//SCORE TEXTS
		if (PlayerData.startGender == 0) {
			scoreGoalTextMeshProText.text = "Transition status from start (" + PlayerData.redBullets + ") to goal (" + PlayerData.blueBullets + ")";
		} else {
			scoreGoalTextMeshProText.text = "Transition status from start (" + PlayerData.blueBullets + ") to goal (" + PlayerData.redBullets + ")";
		}
		if (PlayerData.startGender == 0) {
			scoreArmorTextMeshProText.text = "Armor status from start (" + PlayerData.redArmor + ") to goal (" + PlayerData.blueArmor + ")";
		} else {
			scoreArmorTextMeshProText.text = "Armor status from start (" + PlayerData.blueArmor + ") to goal (" + PlayerData.redArmor + ")";
		}

	}

    public void Spawn() {
        GameObject.Find("Scripts").GetComponent<ContextChanger>().SpawnEnemies(5, 10);
        GameObject player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity) as GameObject;
    }
}
