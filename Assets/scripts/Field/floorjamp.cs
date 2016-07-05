using UnityEngine;
using System.Collections;

public class floorjamp : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		//var tag = GameObject.FindWithTag ("floor");
		rb = GetComponent<Rigidbody> ();
	}
	//物理演算でキャラクターが動く度に呼ばれる処理を設定する事ができます。
	void FixedUpdate()
	{
		

	}

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.tag == "floor")
		{
			rb.AddForce (new Vector3 (0f, 300f, 0f));
		}
	}
	// Update is called once per frame
	void Update () 
	{
		
	}
}
