using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {

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

    public Color GetColorFromGender(int input) {
        return Color.Lerp(Color.blue, Color.red, (float)input / 100f);
    }

}
