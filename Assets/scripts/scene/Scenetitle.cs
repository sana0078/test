using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scenetitle : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	public void ClickScene()
	{
		SceneManager.LoadScene ("StageSelect");
	}


	// Update is called once per frame
	void Update () {

	}
}