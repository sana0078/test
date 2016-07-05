using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StageOne : MonoBehaviour {

	sceneStage ss;

	public GameObject stage;
	// Use this for initialization
	void Start () {
	
	}


	public void ClickScene()
	{
		
			
		SceneManager.LoadScene ("stage1");
		ss.scenestage (stage);

	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
