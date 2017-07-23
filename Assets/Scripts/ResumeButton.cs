using UnityEngine;
using System.Collections;

public class ResumeButton : MonoBehaviour {

	public void HidePopup () {
		GameObject.Find("Pause Screen").SetActive(false);
	}
}
