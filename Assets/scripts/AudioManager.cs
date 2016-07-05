using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public static AudioManager instance;
	public AudioClip audioClip;
	AudioSource audioSource;


	void Awake()
	{
		if (instance != null) {
			Destroy (this.gameObject);
		} else if (instance == null) {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = audioClip;
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
