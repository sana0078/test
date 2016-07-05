using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//Stopwatchクラスを使うため
using System.Diagnostics;
//時間を操る
using System.Threading;
using System;

public class GetTime : MonoBehaviour {
	public Bottom bm;
	public double timer = 0;

	//小数点の変数
	private int secondDecimalPlace = 2;
	//初期化
	private int initialization = 0;

	Text tx;



	void Start () 
	{
		//float型からint型へCastして、string型に変換して表示
		GetComponent<Text> ().text = (timer).ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
		Delete ();
		if (!bm.goTitle) {
			timer += Time.deltaTime;
			//小数点2に変更
			timer = Math.Round (timer, secondDecimalPlace, MidpointRounding.AwayFromZero);
			GetComponent<Text> ().text = (timer).ToString ();

		} 
	}
	void Delete(){
		if (Input.GetKeyDown (KeyCode.F1)) {
			timer = initialization;
			PlayerPrefs.DeleteKey ("timer");
		}
	}
}
