using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	private Vector3 inputValue;
	private NetworkTransform networkTransform;

	void Start () {
		networkTransform = GetComponent<NetworkTransform>();
	}

	public override void OnStartLocalPlayer() {
		GetComponentInChildren<Camera>().enabled = true;
	}

	void Update () {
		if(!isLocalPlayer) return;

		inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis("Vertical");
		transform.Translate(inputValue);
	}
}
