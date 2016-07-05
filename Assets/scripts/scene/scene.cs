using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour {
	Rigidbody rb;
	public Bottom bm;

	private int second = 3;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.tag == "clearfloor")
		{
			Invoke ("Call", second);

		}
	}

	void Call()
	{
		SceneManager.LoadScene("StageSelect");
		bm.goTitle = false;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
