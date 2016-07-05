﻿using UnityEngine;
using System.Collections;

public class MainSound : MonoBehaviour {
	public bool DontDestroyEnabled = true;
	// Use this for initialization
	void Start () {
		
		if (DontDestroyEnabled) 
		{
			DontDestroyOnLoad (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
