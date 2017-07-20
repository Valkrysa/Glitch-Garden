using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {

	public enum Status {SUCCESS, FAILURE};

	private int stars = 100;
	private Text starText;

	// Use this for initialization
	void Start () {
		starText = GetComponent<Text>() as Text;
		UpdateDisplay ();
	}
	
	public void AddStars (int amount) {
		stars += amount;
		UpdateDisplay ();
	}
	
	public Status UseStars (int amount) {
		if (stars >= amount) {
			stars -= amount;
			UpdateDisplay ();
			return Status.SUCCESS;
		}
		
		return Status.FAILURE;
	}
	
	private void UpdateDisplay () {
		starText.text = stars.ToString();
	}
}
