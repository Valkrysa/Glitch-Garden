using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	[Range (1f, 300f)]
	public float levelSeconds = 120f;
	
	private Slider slider;
	private LevelManager levelManager;
	private bool isEndOfLevel = false;
	private AudioSource audioSource;
	private GameObject winLabel;
	
	// private MusicManager musicManager;

	void Start () {
		slider = GetComponent<Slider>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		audioSource = GetComponent<AudioSource>();
		FindYouWin ();
		winLabel.SetActive(false);
		
		// musicManager = GameObject.FindObjectOfType<MusicManager> ();
	}

	void FindYouWin ()
	{
		winLabel = GameObject.Find ("You Win");
		if (!winLabel) {
			Debug.LogWarning ("Please create You Win object.");
		}
	}
	
	void LoadNextLevel () {
		levelManager.LoadNextLevel();
	}
	
	void Update () {
		bool timeIsUp = Time.timeSinceLevelLoad >= levelSeconds;
		if (timeIsUp && !isEndOfLevel) {
			isEndOfLevel = true;
			audioSource.Play();
			winLabel.SetActive(true);
			Invoke("LoadNextLevel", audioSource.clip.length);
			
			// musicManager.PlayVictory();
		} else {
			slider.value = Time.timeSinceLevelLoad / levelSeconds;
		}
	}
}
