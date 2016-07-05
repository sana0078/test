using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//using System.Diagnostics;

public class ClearLine : MonoBehaviour {
	public GameObject GameClear;
	public playermaneger pm;
	public Bottom bm;
	public GetTime gt;
	public bool gameClear = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		GameClear.SendMessage ("Clear");
		pm.GetComponent<Rigidbody> ().velocity = Vector3.zero;
	//	gt.sw.Stop ();
		bm.goTitle = true;
		gameClear = true;
	}
}
