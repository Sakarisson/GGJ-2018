using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager i;
    public SpriteRenderer middle;
    public SpriteRenderer left;
    public SpriteRenderer right;

    void Start()
    {
        i = this;
        middle.material.SetColor("_BottomColor", Constants.allowedColors[0]);
        middle.material.SetColor("_TopColor", Constants.allowedColors[1]);
        left.material.SetColor("_BottomColor", Constants.allowedColors[2]);
        left.material.SetColor("_TopColor", Constants.allowedColors[3]);
        right.material.SetColor("_BottomColor", Constants.allowedColors[4]);
        right.material.SetColor("_TopColor", Constants.allowedColors[5]);
    }
}
