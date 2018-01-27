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
		//Debug.Log ("ColorManager:"+(ColorManager==null));
		Debug.Log ("ColorManager.i:"+(ColorManager.i==null));
		ColorManager.i.FadeFeminine(false, 0.1f);
		ColorManager.i.FadeMasculine(false, 0.1f);
		ColorManager.i.ScaleRoot (5f,0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showGameCanvas(){
		gameCanvas.SetActive (true);
		hideProfileCanvas ();
		//ColorManager.i.FadeFeminine();
		//ColorManager.i.ScaleRoot
		//ColorManager.i.FadeMasculine();
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
