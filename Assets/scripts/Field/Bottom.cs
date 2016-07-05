using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bottom : MonoBehaviour {
	
	private bool goStage = true;

	public GameObject GameOver;
	public GameObject retry;
	public GameObject stageSelect;
	public bool goTitle = false;
	public playermaneger pm;



	// Use this for initialization
	void Start () 
	{
		//pm = pm.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (goTitle) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				int sceneIndex = SceneManager.GetActiveScene ().buildIndex;
				SceneManager.LoadScene (sceneIndex);
				goTitle = false;
			}
		} 
		else if (goStage) 
		{
			if (Input.GetKeyDown (KeyCode.LeftShift)) 
			{
				
				SceneManager.LoadScene ("StageSelect");
				goStage = false;
			}

		}

	}

	void OnCollisionEnter(Collision col)
	{
		GameOver.SendMessage ("Lose");
		retry.SendMessage ("Lose");
		stageSelect.SendMessage ("Lose");
		pm.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		goTitle = true;
		goStage = true;
	}
}
