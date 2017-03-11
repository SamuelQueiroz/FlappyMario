using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObjects : MonoBehaviour {
	
	private Rigidbody2D rigidb2D;
	public float velocity = 0f;
	private float x;

	private MarioController mario;
	private bool pass;

	public GameObject scoreText;
	private int score;

	// Use this for initialization
	void Start () {

		mario = FindObjectOfType (typeof(MarioController)) as MarioController;

		rigidb2D = GetComponent<Rigidbody2D> ();
		rigidb2D.velocity = new Vector2 (velocity, 0);

		scoreText = GetComponent <GameObject> ();

		score = 0;
	}


	void OnEnable(){
		pass = false;
	}


	// Update is called once per frame
	void Update () {

		x = transform.position.x;

		if (x < mario.transform.position.x && pass == false) {
			pass = true;
			//Debug.Log (score);
			score += 1;
			Debug.Log (score);


		}

		if (x <= -13) {
			Destroy (transform.gameObject);
		}

		if (ControllerScript.instance.gameOver == true) {
			rigidb2D.velocity = Vector2.zero;
		}

	} 

}
