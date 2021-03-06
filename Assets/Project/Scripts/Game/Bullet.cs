﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 8f;
	public float lifeDuration = 2f;

	private float lifeTimer;

	void OnEnable () {
		lifeTimer = lifeDuration;
	}
	
	void Update () {
		// Make the bullet move.
		transform.position += transform.forward * speed * Time.deltaTime;

		// Check if bullet should be destroyed.
		lifeTimer -= Time.deltaTime;
		if (lifeTimer <= 0f) {
			gameObject.SetActive (false);
		}
	}
}
