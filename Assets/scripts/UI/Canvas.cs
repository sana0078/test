using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Canvas : MonoBehaviour {
	static Canvas canvas;

	// Use this for initialization
	void Start () 
	{
		
		canvas = GetComponent<Canvas> ();
	
	}

	//オブジェクトの名前のboolを切り替え
	public void SetActive(string name, bool b)
	{
		//子オブジェクトを探す
		foreach (Transform child in canvas.transform) 
		{
			if (child.name == name) 
			{
				//boolを切り替える
				child.gameObject.SetActive (b);
				return;
			}
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
