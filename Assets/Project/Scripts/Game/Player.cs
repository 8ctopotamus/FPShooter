using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Camera playerCamera;
	public int ammo;

	void Start () {
		
	}
		
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject bulletObject = ObjectPoolingManager.Instance.GetBullet ();
			bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
			bulletObject.transform.forward = playerCamera.transform.forward;
		}
	}
}
