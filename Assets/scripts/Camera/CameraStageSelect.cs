using UnityEngine;
using System.Collections;

public class CameraStageSelect : MonoBehaviour {

	public SubCamera sc;

	public GameObject selectCanvas;
	public GameObject stageCanvas;



	// Use this for initialization
	void Start () {
		selectCanvas.SetActive(false);

	}

	public void SelectStage()
	{
		selectCanvas.SetActive(false);
		stageCanvas.SetActive (true);


		sc.firstPersonCamera.enabled = true;
		sc.overheadCamera.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
