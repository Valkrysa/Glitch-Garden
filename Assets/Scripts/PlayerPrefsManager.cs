﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	
	public static void SetDifficulty (float difficulty) {
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError ("Difficulty out of range: " + difficulty);
		}
	}
	
	public static float GetDifficulty () {
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}

	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Master volume out of range: " + volume);
		}
	}
	
	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY, 0.3f);
	}
	
	public static void UnlockLevel (int level) {
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1); // use 1 for true
		} else {
			Debug.LogError ("Trying to unlock level not in build order.");
		}
	}
	
	public static bool IsLevelUnlocked (int level) {
		int targetLevel = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (targetLevel == 1);
		
		if (level <= Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("Checking the unlock status of a level not in build order.");
			return false;
		}
	}

}
