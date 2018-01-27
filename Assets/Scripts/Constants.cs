using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour {
    private Color32[] allowedColors = {
        new Color32(79, 203, 225, 255),
        new Color32(47, 142, 221, 255),
        new Color32(214, 209, 47, 255),
        new Color32(76, 213, 51, 255),
        new Color32(255, 192, 20, 255),
        new Color32(245, 14, 0, 255),
        new Color32(224, 91, 82, 255),
        new Color32(184, 178, 176, 255),
    };

    public Color32[] GetAllowedColors() {
        return allowedColors;
    }

    public Color GetRandomAllowedColor(Color currentColor) {
        while (true) {
            Color randomColor = allowedColors[Random.Range(0, allowedColors.Length)];
            if (randomColor != currentColor) {
                return randomColor;
            }
        }
    }
}
