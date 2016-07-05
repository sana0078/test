using UnityEngine;
using System.Collections;

public class SdController : MonoBehaviour {
	public GameObject player;

	float right = 90.0f;
	float down=180.0f;
	float left=270.0f;
	float up=0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position;
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.eulerAngles= new Vector3(0,right,0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.eulerAngles= new Vector3(0,down,0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.eulerAngles= new Vector3(0,left,0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.eulerAngles= new Vector3(0,up,0);
		}

	}
}
