using UnityEngine;
using System.Collections;

public class shooter : MonoBehaviour {

	public GameObject projectile;

	private GameObject projectileParent;
	private Animator animator;
	private Spawner myLaneSpawner;
	
	void Start () {
		animator = GetComponent<Animator>();
		
		projectileParent = GameObject.Find("Projectiles");
		
		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}
		
		SetMyLaneSpawner ();
	}
	
	void Update () {
		if (IsAttackerAheadInLane()) {
			animator.SetBool ("isAttacking", true);
		} else {
			animator.SetBool ("isAttacking", false);
		}
	}
	
	void SetMyLaneSpawner () {
		Spawner[] spawners = GameObject.FindObjectsOfType<Spawner>();
		
		foreach (Spawner spawner in spawners) {
			if (spawner.transform.position.y == transform.position.y) {
				myLaneSpawner = spawner;
				return;
			}
		}
		
		Debug.LogError (name + " can't find spawner in lane");
	}
	
	bool IsAttackerAheadInLane () {
		if (myLaneSpawner.transform.childCount <= 0) {
			return false;
		}
		
		foreach (Transform attacker in myLaneSpawner.transform) {
			if (attacker.transform.position.x > transform.position.x) {
				return true;
			}
		}

		return false;
	}
	
	private void Fire () {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.SetParent(projectileParent.transform);
		
		GameObject gun = transform.Find("Gun").gameObject; // could have just dragged this her in the inspector but I wanted to show an alternative to the way ben is doing it
		
		if (gun) {
			newProjectile.transform.position = gun.transform.position;
		} else {
			Debug.Log("Could not find child by the name of Gun");
		}
	}
}
