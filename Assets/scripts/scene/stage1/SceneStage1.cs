using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneStage1 : MonoBehaviour {


	sceneStage ss;

	public GameObject stage;
	public GameObject canvasStage;


	public GameObject canvasSelect;


	public SubCamera sc;
	public PrefabInstance pi;




	// Use this for initialization

	public static SceneStage1 Instance {
		get;
		private set;
	}

	void Awake()
	{
		if (Instance != null) 
		{
			Destroy (gameObject);
			return;
		}
		Instance = this;
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		
	}



	public void ClickScene()
	{
		//ボタン非表示
		canvasStage.SetActive(false);
		canvasSelect.SetActive(true);

		sc.ShowFirstPersonView ();

		pi.prefabInstance (stage);

	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
