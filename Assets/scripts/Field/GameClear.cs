using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameClear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Clear(){
		gameObject.GetComponent<Text> ().enabled = true;
	}
}
