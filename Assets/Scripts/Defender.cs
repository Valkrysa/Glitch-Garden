using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	[Range (0, 500)]
	public int starCost = 100;

	private StarDisplay starDisplay;
	
	public void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	public void AddStars (int amount) {
		starDisplay.AddStars(amount);
	}
}
