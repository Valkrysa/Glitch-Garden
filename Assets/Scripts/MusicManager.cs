﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	public AudioClip victoryMusic;

	private AudioSource audioSource;
	
	void Awake(){
		DontDestroyOnLoad(gameObject);
	}

	void Start(){
		audioSource = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level) {
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		if(thisLevelMusic){
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	
	public void SetVolume (float volume) {
		audioSource.volume = volume;
	}
	
	public void PlayVictory () {
		audioSource.clip = victoryMusic;
		audioSource.Play();
	}

}
