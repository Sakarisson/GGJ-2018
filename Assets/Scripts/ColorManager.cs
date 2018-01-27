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
    public float scaleTime = 5;
    public float scaleSize = 5;
    public float fadeInTime = 60;

    void Start()
    {
        i = this;
        StartCoroutine(ScaleRoot());
        StartCoroutine(FadeIn(FeminineRenderer));
        StartCoroutine(FadeIn(MasculineRenderer));
    }


    IEnumerator FadeIn(SpriteRenderer renderer)
    {
        float t = 0;
        Color32 startColor = Color.white;
        Color32 endColor = renderer.material.GetColor("_BottomColor");
        endColor.a = 0;

        while (t < 1)
        {
            t += Time.deltaTime / fadeInTime;
            Color32 newColor = Color.Lerp(startColor, endColor, t);
            renderer.material.SetColor("_BottomColor",newColor);
            yield return null;
        }
    }

    IEnumerator ScaleRoot()
    {
        float t = scaleTime;
        while (t > 1)
        {
            t -= Time.deltaTime;
            ChangeScale(t);
            yield return null;
        }
    }

    void ChangeScale(float value)
    {
        rootFace.transform.localScale = new Vector3(value, value, value);
    }

    public void ChangeColor(float t)
    {
        Color col = Color.Lerp(masculine, feminine, t);
        playerRenderer.material.SetColor("_BottomColor", col);
    }
}
