using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

	Animator animator;


	public void startAnimation(){
		if (animator) {
			animator.Play ("Standing@loop");
		}
	}
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		startAnimation ();
	}



	public void changeAnimation(){
		if (Input.GetKey (KeyCode.RightArrow)||Input.GetKey (KeyCode.LeftArrow)||Input.GetKey (KeyCode.UpArrow)||Input.GetKey (KeyCode.DownArrow)) {
			animator.SetBool ("Next", true);
			animator.SetBool ("Back", false);
		}
		else
			animator.SetBool ("Next", false);
			animator.SetBool ("Back", true);
	}

	
	// Update is called once per frame
	void Update () {
		
			changeAnimation();

		/*if (Input.GetKeyUp (KeyCode.Space)) {
			changeAnimation_Back ();
		}*/

	}
}
