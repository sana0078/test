using UnityEngine;
using System.Collections;

public class PrefabInstance : MonoBehaviour {
	float rotation;

	/*static private PrefabInstance instance = null;

	static public PrefabInstance Instance
	{
		get{ return PrefabInstance.instance;}
	}

*/


	// Use this for initialization
	void Start () {

	}


	//static bool f = false;
	public void prefabInstance(GameObject name)
	{
		
		/*
		if (!f) {
			f = true;
			Instantiate (name, new Vector3 (0,-4,-29), Quaternion.identity);
		}
		*/

		/*
		GameObject clone = name;
		if (name != null) 
		{
			Destroy (name);
			Debug.Log ("asd");
			return;
		}


		*/
		Instantiate (name, new Vector3 (0,-4,-29), Quaternion.identity);

	}

	// Update is called once per frame
	void Update () {
		//Quaternionの回転
		rotation += (Time.deltaTime*10);
		this.transform.rotation = Quaternion.Euler (0,rotation,0);
	}
}
