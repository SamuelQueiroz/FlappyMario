﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour {

	public float forcaPulo = 200f;

	private bool isDead = false;
	private Rigidbody2D rigid2D;
	private Animator anim;

	// Use this for initialization
	void Start () {

		rigid2D = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (isDead == false) {

			if (Input.GetMouseButtonDown (0)) {
				rigid2D.velocity = Vector2.zero;
				rigid2D.AddForce (new Vector2 (0, forcaPulo));


				anim.SetTrigger ("Fly");
			}
		
		}
		
	}

	void OnCollisionEnter2D (){
		isDead = true;
		anim.SetTrigger ("Die");
		ControllerScript.instance.MaroDie ();
	}
}
