using UnityEngine;
using System.Collections;

public class StopButton : MonoBehaviour {

	public GameObject pauseScreen;
	public GameObject coreGame;

	void OnMouseDown () {
		pauseScreen.SetActive(true);
		coreGame.GetComponent<DefenderSpawner>().paused = true;
		Time.timeScale = 0f;
	}
}
