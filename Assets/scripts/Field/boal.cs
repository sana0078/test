using UnityEngine;
using System.Collections;

public class boal : MonoBehaviour {
	public GameObject Myprefab;

	// Use this for initialization
	void Start () {
		Instantiate (Myprefab, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
