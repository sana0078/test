using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubCamera : MonoBehaviour {
	public Camera firstPersonCamera;
	public Camera overheadCamera;

	// Use this for initialization
	void Start () {
		firstPersonCamera.enabled = true;
		overheadCamera.enabled = false;

	}

	public void ShowFirstPersonView()
	{
		firstPersonCamera.enabled = false;
		overheadCamera.enabled = true;

	}

	// Update is called once per frame
	void Update () {
	
	}
}
