using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour {

	public float fadeInTime;
	
	private Image fadePanel;

	void Start () {
		fadePanel = GetComponent<Image>();
		
		fadePanel.CrossFadeAlpha(0f, fadeInTime, false);
	}
	
	void Update(){
		if(Time.timeSinceLevelLoad >= fadeInTime){
			gameObject.SetActive(false);
		} else {
			// Ben's Method
			// I use CrossFadeAlpha instead
			// float alphaChange = Time.deltaTime / fadeInTime;
			// currentColor.a -= alphaChange;
			// fadePanel.color = currentColor;
		}
	}
	
}
