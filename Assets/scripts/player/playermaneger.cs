using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playermaneger : MonoBehaviour {
	public Bottom bm;
	public ClearLine cl;
	
	Rigidbody rigid;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		if (!bm.goTitle) {
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rigid.AddForce (movement * 10);
		}
	}
}
