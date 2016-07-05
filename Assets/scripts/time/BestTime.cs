using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BestTime : MonoBehaviour {
	public GetTime gt;
	public Bottom bm;
	public ClearLine cl;
	private float bestTime;
	private static float score = 100;
	// Use this for initialization
	void Start () 
	{
		//データを読み込むとき
		PlayerPrefs.GetFloat ("score");
		GetComponent<Text> ().text = (score).ToString ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (gt.timer < score && bm.goTitle && cl.gameClear) 
		{
			GetComponent<Text> ().text = (score).ToString ();
			bestTime = (float)gt.timer;
			//データを保存するとき
			PlayerPrefs.SetFloat ("bestTime", bestTime);
			score = bestTime;
			Debug.Log ("asd"+bestTime);
		}


	}
}
