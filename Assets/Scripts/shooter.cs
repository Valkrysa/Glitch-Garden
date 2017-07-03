using UnityEngine;
using System.Collections;

public class shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject projectileParent;
	
	private void Fire () {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.SetParent(projectileParent.transform);
		
		GameObject gun = GameObject.Find("Gun"); // could have just dragged this her in the inspector but I wanted to show an alternative to the way ben is doing it
		
		if (gun) {
			newProjectile.transform.position = gun.transform.position;
		} else {
			Debug.Log("Could not find child by the name of Gun");
		}
	}
}
