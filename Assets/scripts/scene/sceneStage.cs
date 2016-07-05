using UnityEngine;
using System.Collections;

public class sceneStage : MonoBehaviour {

	//public GameObject go;

	// Use this for initialization
	void Start () 
	{
		
	}

	public void scenestage(GameObject name)
	{
		Instantiate (name, new Vector3 (0,0,0), Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
