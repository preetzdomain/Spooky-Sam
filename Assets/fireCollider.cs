﻿using UnityEngine;
using System.Collections;

public class fireCollider : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.tag == "Player") {
			Prefs.playerHealth -= 10;
		}
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
