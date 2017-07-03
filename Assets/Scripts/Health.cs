using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[Range (0f, 100f)]
	public float health = 100f;

	public void DealDamage (float damage) {
		health -= damage;
		
		if (health <= 0) {
			// maybe trigger an animation
			DestroyObject();
		}
	}
	
	public void DestroyObject () {
		Destroy(gameObject);
	}
}
