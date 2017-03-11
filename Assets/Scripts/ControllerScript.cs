﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScript : MonoBehaviour {

	public static ControllerScript instance;

	public GameObject gameOverObject;
	public bool gameOver = false;

	public float scrollSpeed = -1.5f;


	// Use this for initialization
	void Awake () {

		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameOver == true && Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
		
	}

	public void MaroDie(){

		gameOverObject.SetActive (true);
		gameOver = true;
	}
}
