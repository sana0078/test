using UnityEngine;
using System.Collections;

public class fieldManeger : MonoBehaviour {
	public float x = 0;
	public float y = 0;
	public float z = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (x, y, z);

	}
}
