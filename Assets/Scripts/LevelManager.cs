using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;
	
	void Start(){
		if (autoLoadNextLevelAfter <= 0) {
			Debug.LogWarning ("Level auto load disabled, use a positive number in seconds");
		} else {
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name){
		Application.LoadLevel(name);
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void QuitRequest(){
		Application.Quit();
	}
	
}
