using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Rigidbody rigid;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}



	// Update is called once per frame
	void Update () {
		

		if (Input.GetKeyDown (KeyCode.Space)) {
			rigid.AddForce (new Vector3(0f,300f,0f));
			//Debug.Log (Hello("hello", "world"));
			//Hello ("hello world");
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rigid.AddForce (new Vector3 (10f, 0f, 0f));
		}

		else if (Input.GetKey (KeyCode.LeftArrow)) {
			rigid.AddForce (new Vector3 (-10f, 0f, 0f));
		}
		else if (Input.GetKey (KeyCode.UpArrow)) {
			rigid.AddForce (new Vector3 (0f, 0f, 10f));
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			rigid.AddForce (new Vector3 (0f, 0f, -10f));
		}

	}
	//文字列を引数で渡して連結して戻すやり方
	public string Hello(string a,string b){
		return a + " " + b;
		//Debug.Log (a);
	}
}
