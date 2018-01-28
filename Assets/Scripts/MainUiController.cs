using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUiController : MonoBehaviour {

	public GameObject profileCanvas;
	public GameUiController gameUiControllerCanvas;
	public GameObject menuButton;
	float timer = 0f;
	float zoomLevel = 1f;

	// Use this for initialization
	void Start () {
		hideGameCanvas ();
		showProfileCanvas ();
		//Debug.Log ("ColorManager:"+(ColorManager==null));
		Debug.Log ("ColorManager.i:"+(ColorManager.i==null));
		//ColorManager.i.FadeFeminine(false, 0.01f);
		//ColorManager.i.FadeMasculine(false, 0.01f);
		//ColorManager.i.FadeMasculine(true, 0.01f);
		ColorManager.i.ScaleRoot (5f,0.01f);
	}
	
	// Update is called once per frame
	void Update () {
		//UPDATE ZOOM LEVEL
		timer += Time.deltaTime;
		if (timer > 10) {
			zoomLevel++;
			if (zoomLevel > 5)
				zoomLevel = 0f;

			timer = UnityEngine.Random.Range (3f,10f);
			ColorManager.i.ScaleRoot (zoomLevel,3f);
		}
	}

	public void showGameCanvas(){
		hideProfileCanvas ();
		gameUiControllerCanvas.gameObject.SetActive (true);
		gameUiControllerCanvas.initializeUi ();

		//ColorManager.i.FadeFeminine();
		//ColorManager.i.ScaleRoot
		//ColorManager.i.FadeMasculine();
	}

	public void showProfileCanvas(){
		profileCanvas.SetActive (true);
		hideGameCanvas ();
	}

	public void hideGameCanvas(){
		GameObject.Find ("Scripts").GetComponent<ContextChanger> ().enabled = false;
		gameUiControllerCanvas.gameObject.SetActive (false);
	}

	public void hideProfileCanvas(){
		profileCanvas.SetActive (false);
	}

}
