using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	int b;
	int c;
	// Use this for initialization
	void Start () {
		asd (3);

		asd (5);
		asd (4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void asd(int a)
	{
		Debug.Log (a);

	}
}
