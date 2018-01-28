using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager i;
    public SpriteRenderer playerRenderer;
    public SpriteRenderer FeminineRenderer;
    public SpriteRenderer MasculineRenderer;
    public Color masculine;
    public Color feminine;
    public GameObject rootFace;
    public float fadeInTime = 60;

	public float lastScaleValue = -1f;
	public bool lastFeminineVisible = false;
	public bool lastMasculineVisible = false;

    public Coroutine scaleRoot;
    public Coroutine faceCenter;
    public Coroutine fadeLeft;
    public Coroutine fadeRight;

    void Awake()
    {
        i = this;
        //ScaleRoot(5, 5);
        //FadeFeminine(false, 0.1f);
        //FadeFeminine(true, 0.1f);
        //FadeMasculine(false, 10);
    }

    public void ScaleRoot(float size, float time)
    {
        if (scaleRoot != null) StopCoroutine(scaleRoot);
		lastScaleValue = size;
        scaleRoot = StartCoroutine(_ScaleRoot(size, time));
    }

    IEnumerator _ScaleRoot(float scale, float time)
    {
        Vector3 oldScale = rootFace.transform.localScale;
        Vector3 newScale = Vector3.one * scale;

        float t = 0f;
        while (t < time)
        {
            t += Time.deltaTime;
            rootFace.transform.localScale = Vector3.Slerp(oldScale, newScale, t / time);
            yield return null;
        }
    }


    public void FadeMasculine(bool visible, float time)
    {
		lastMasculineVisible = visible;
        if (fadeLeft != null) StopCoroutine(fadeLeft);
        if (visible)
            fadeLeft = StartCoroutine(_FadeIn(time, MasculineRenderer));
        else
            fadeLeft = StartCoroutine(_FadeOut(time, MasculineRenderer));
    }
    public void FadePlayer(bool visible, float time)
    {
        if (fadeLeft != null) StopCoroutine(fadeLeft);
        if (visible)
            fadeLeft = StartCoroutine(_FadeIn(time, playerRenderer));
        else
            fadeLeft = StartCoroutine(_FadeOut(time, playerRenderer));
    }
    public void FadeFeminine(bool visible, float time)
    {
		lastFeminineVisible = visible;
        if (fadeRight != null) StopCoroutine(fadeRight);
        if (visible)
            fadeRight = StartCoroutine(_FadeIn(time, FeminineRenderer));
        else
            fadeRight = StartCoroutine(_FadeOut(time, FeminineRenderer));
    }

    IEnumerator _FadeIn(float time, SpriteRenderer renderer)
    {
        float t = 0;
        Color32 startColor = Color.white;
        Color32 endColor = renderer.material.GetColor("_BottomColor");
        endColor.a = 0;

        while (t < time)
        {
            t += Time.deltaTime / fadeInTime;
            Color32 newColor = Color.Lerp(startColor, endColor, t / time);
            renderer.material.SetColor("_BottomColor", newColor);
            yield return null;
        }
    }

    IEnumerator _FadeOut(float time, SpriteRenderer renderer)
    {
        float t = 0;
        Color32 startColor = renderer.material.GetColor("_BottomColor");
        Color32 endColor = Color.white;
        endColor.a = 0;

        while (t < time)
        {
            t += Time.deltaTime;
            Color32 newColor = Color.Lerp(startColor, endColor, t / time);
            renderer.material.SetColor("_BottomColor", newColor);
            yield return null;
        }
    }
    public void ChangeColor(float t)
    {
        Color col = Color.Lerp(masculine, feminine, t);
        playerRenderer.material.SetColor("_BottomColor", col);
    }
}
