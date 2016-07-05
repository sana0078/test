using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver :  MonoBehaviour {

	//public Button bn;


	// Use this for initialization
	void Start () 
	{
		
		gameObject.GetComponent<Text> ().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Lose()
	{
		
		gameObject.GetComponent<Text> ().enabled = true;
		//Canvas.SetActive ("Button", true);
	
	}
}
