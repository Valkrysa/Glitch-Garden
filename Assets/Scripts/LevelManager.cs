using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;
	public GameObject pauseScreen;
	public GameObject coreGame;
	
	void Start(){
		if (autoLoadNextLevelAfter <= 0) {
			Debug.LogWarning ("Level auto load disabled, use a positive number in seconds");
		} else {
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name){
		Time.timeScale = 1f;
		Application.LoadLevel(name);
	}
	
	public void LoadNextLevel(){
		Time.timeScale = 1f;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void QuitRequest(){
		Application.Quit();
	}
	
	public void HidePauseScreen () {
		pauseScreen.SetActive(false);
		coreGame.GetComponent<DefenderSpawner>().paused = false;
		Time.timeScale = 1f;
	}
	
}
