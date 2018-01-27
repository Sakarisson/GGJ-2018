using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUiController : MonoBehaviour {

	public GameObject profileCanvas;
	public GameObject gameCanvas;
	public GameObject menuButton;

	// Use this for initialization
	void Start () {
		hideGameCanvas ();
		showProfileCanvas ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showGameCanvas(){
		gameCanvas.SetActive (true);
	}

	public void showProfileCanvas(){
		profileCanvas.SetActive (true);
	}

	public void hideGameCanvas(){
		gameCanvas.SetActive (false);
	}

	public void hideProfileCanvas(){
		profileCanvas.SetActive (false);
	}

}
