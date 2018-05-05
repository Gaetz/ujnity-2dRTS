using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHudNetworkManager : NetworkManager {

	private NetworkManager networkManager;

	public void MyStartHost() {
		StartHost();
	}

	public override void OnStartHost() {
		Debug.Log("Host started");
	}

	public override void OnStartClient(NetworkClient myClient) {
		Debug.Log("Client started");
		InvokeRepeating("PrintDots", 0f, 0.1f);
	}

	public override void OnClientConnect(NetworkConnection conn) {
		Debug.Log("Client connected to " + conn.address);
		CancelInvoke();
	}

	void PrintDots() {
		Debug.Log(".");
	}
}
