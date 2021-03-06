﻿using UnityEngine;
using System.Collections;

public class Crumbler : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator crumble(Collider other) {
		yield return new WaitForSeconds (2.0f);
		other.transform.parent = null;
		Destroy (gameObject);
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			StartCoroutine (crumble (other));
		}
	}
}