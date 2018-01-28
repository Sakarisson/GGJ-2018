using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro.Examples;
using TMPro;

public class UiTeleTextController : MonoBehaviour {



	//[Range(0, 100)]
	//public int RevealSpeed = 50;

	public string label01 = "Example 1 <sprite=2> of using <sprite=7> <#ffa000>Graphics Inline</color> <sprite=5> with Text in <font=\"Bangers SDF\" material=\"Bangers SDF - Drop Shadow\">TextMesh<#40a0ff>Pro</color></font><sprite=0> and Unity<sprite=1>";
	public string label02 = "Example 2 <sprite=2> of using <sprite=7> <#ffa000>Graphics Inline</color> <sprite=5> with Text in <font=\"Bangers SDF\" material=\"Bangers SDF - Drop Shadow\">TextMesh<#40a0ff>Pro</color></font><sprite=0> and Unity<sprite=2>";


	private TMP_Text m_textMeshPro;
	private int txtcounter = 0;

	void Awake()
	{
		// Get Reference to TextMeshPro Component
		m_textMeshPro = GetComponent<TMP_Text>();
		/*
		if (counter > 0) {
			m_textMeshPro.text = label02;
			counter = 0;
		} else {
			m_textMeshPro.text = label01;
		}
		*/
		m_textMeshPro.text = label01;
		m_textMeshPro.enableWordWrapping = true;
		m_textMeshPro.alignment = TextAlignmentOptions.Top;

		//counter++;

		//if (GetComponentInParent(typeof(Canvas)) as Canvas == null)
		//{
		//    GameObject canvas = new GameObject("Canvas", typeof(Canvas));
		//    gameObject.transform.SetParent(canvas.transform);
		//    canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;

		//    // Set RectTransform Size
		//    gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(500, 300);
		//    m_textMeshPro.fontSize = 48;
		//}


	}


	IEnumerator Start()
	{

		// Force and update of the mesh to get valid information.
		m_textMeshPro.ForceMeshUpdate();


		int totalVisibleCharacters = 100; // m_textMeshPro.textInfo.characterCount; // Get # of Visible Character in text object
		int counter = 0;
		int visibleCount = 0;

		while (true)
		{
			visibleCount = counter % (totalVisibleCharacters + 1);

			m_textMeshPro.maxVisibleCharacters = visibleCount; // How many characters should TextMeshPro display?

			// Once the last character has been revealed, wait 1.0 second and start over.
			if (visibleCount >= totalVisibleCharacters)
			{
				

				yield return new WaitForSeconds(3.0f);
				if (txtcounter > 0) {
					m_textMeshPro.text = label02;
					txtcounter = 0;
				} else {
					m_textMeshPro.text = label01;
					txtcounter++;
				}
				//m_textMeshPro.text = label02;
				//yield return new WaitForSeconds(3.0f);
				//m_textMeshPro.text = label01;
				//yield return new WaitForSeconds(3.0f);
			}

			counter += 1;

			yield return new WaitForSeconds(0.05f);
		}

		//Debug.Log("Done revealing the text.");
	}

}
