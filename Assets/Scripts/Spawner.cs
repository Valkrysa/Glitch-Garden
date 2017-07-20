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
	
	public bool isTimeToSpawn (GameObject attackerPassed) {
		Attacker attacker = attackerPassed.GetComponent<Attacker>();
		
		float meanSpawnDelay = attacker.seenEverySeconds;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		
		if (Time.deltaTime > meanSpawnDelay) {
			Debug.LogWarning ("Spawn rate capped by frame rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime / 5; // 5 lanes
		
		return (Random.value < threshold);
	}
	
	public void Spawn (GameObject myGameObject) {
		GameObject newSpawn = Instantiate(myGameObject) as GameObject;
		newSpawn.transform.SetParent(gameObject.transform);
		newSpawn.transform.position = gameObject.transform.position;
	}
}
