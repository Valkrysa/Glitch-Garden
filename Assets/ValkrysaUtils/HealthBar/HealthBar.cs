using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    private Health myHealthComponent;
    private Slider myHealthBar;
    private float maxHealth;

	// Use this for initialization
	void Start () {
        myHealthComponent = GetComponentInParent<Health>();
        myHealthBar = GetComponentInChildren<Slider>();
        maxHealth = myHealthComponent.health;
        myHealthBar.maxValue = maxHealth;
    }
	
	// Update is called once per frame
	void Update () {
        myHealthBar.value = myHealthComponent.health;
    }
}
