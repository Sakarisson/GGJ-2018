using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextChanger : MonoBehaviour {
    // Public data members
    public float changeTime = 2f;

    // Private data members
    private ArrayList spawnableObjects = new ArrayList();

    void Start() {
        // Find all items to be changed
        Initialize();

        // Debug
        Change();
    }

    private void Initialize() {
        var objects = GameObject.FindGameObjectsWithTag("spawnable");
        foreach (GameObject obj in objects) {
            spawnableObjects.Add(obj);
        }
        Debug.Log(spawnableObjects[1]);
    }

    public Color GetRandomAllowedColor(Color currentColor)
    {
        Color[] allowedColors = Constants.allowedColors;
        while (true)
        {
            Color randomColor = allowedColors[Random.Range(0, allowedColors.Length)];
            if (randomColor != currentColor) {
                return randomColor;
            }
        }
    }

    public void Change() {
        StartCoroutine(ChangeColor(Color.magenta));
    }

    private IEnumerator ChangeColor(Color endColor) {
        yield return FadeToColor(Color.white);
        yield return new WaitForSeconds(1);
        yield return FadeToColor(endColor);
    }

    private IEnumerator FadeToColor(Color color) {
        float elapsedTime = 0f;
        float fadeTime = changeTime / 2f;
        Renderer objectRenderer = gameObject.GetComponent<Renderer>();
        Color currentColor = objectRenderer.material.color;
        while (elapsedTime < fadeTime) {
            elapsedTime += Time.deltaTime;
            objectRenderer.material.color = Color.Lerp(currentColor, color, (elapsedTime / fadeTime));
            yield return null;
        }
    }
}
