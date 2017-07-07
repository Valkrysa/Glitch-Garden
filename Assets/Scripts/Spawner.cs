using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] attackerPrefabArray;
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisAttacker in attackerPrefabArray) {
			if (isTimeToSpawn(thisAttacker)) {
				Spawn (thisAttacker);
			}
		}
	}
	
	public bool isTimeToSpawn (GameObject attacker) {
		return true;
	}
	
	public void Spawn (GameObject myGameObject) {
		GameObject newSpawn = Instantiate(myGameObject) as GameObject;
		newSpawn.transform.SetParent(gameObject.transform);
		newSpawn.transform.position = gameObject.transform.position;
	}
}
