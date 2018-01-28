using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {
    public static Color32 Pink = new Color32(255, 88, 188, 255);
    public static Color32 LightBlue = new Color32(79, 203, 225, 255);

	/// <summary>
	/// The current gender state. Values from 0 to 100.
	/// 0 = masculine, 100 = feminine
	/// </summary>
	public static int gender = 0;

	/// <summary>
	/// The initial gender value in the beginning of the game. Values from 0 to 100.
	/// 0 = masculine, 100 = feminine
	/// </summary>
	public static int startGender = 0;

	/// <summary>
	/// The target gender value. The goal of the game. Values from 0 to 100.
	/// 0 = masculine, 100 = feminine
	/// </summary>
	public static int goalGender = 0;

	/// <summary>
	/// The current armour state. Values from 0 to 100.
	/// 0 = masculine, 100 = feminine
	/// </summary>
	public static int armour = 0;

	/// <summary>
	/// The initial armour value in the beginning of the game. Values from 0 to 100.
	/// 0 = masculine, 100 = feminine
	/// </summary>
	public static int startArmour = 0;

	/// <summary>
	/// The target armour value. The goal of the game. Values from 0 to 100.
	/// 0 = masculine, 100 = feminine
	/// </summary>
	public static int goalArmour = 0;

    public Color GetColorFromGender(int input) {
        return Color.Lerp(LightBlue, Pink, (float)input / 100f);
    }

}
