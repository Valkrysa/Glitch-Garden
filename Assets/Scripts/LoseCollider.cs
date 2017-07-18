using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		// levelManager = gameObject.AddComponent<LevelManager>();
	}
	
	void OnTriggerEnter2D () {
		levelManager.LoadLevel("03b_Lose");
	}
}
