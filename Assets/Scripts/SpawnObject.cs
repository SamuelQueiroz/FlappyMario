using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

	public GameObject enemyPrefab;
	public float tempoSpawn = 0f;
	public float currentTime = 0f;
	private float posicaoY;


	// Use this for initialization
	void Start () {

		currentTime = 0;
		
	}
	
	// Update is called once per frame
	void Update () {


		currentTime += Time.deltaTime;

		if (ControllerScript.instance.gameOver != true){
			if (currentTime >= tempoSpawn) {

				currentTime = 0f;
				posicaoY = Random.Range (-3,4);
				GameObject enemyTemp = Instantiate (enemyPrefab) as GameObject;
				enemyTemp.transform.position = new Vector3 (transform.position.x, posicaoY, enemyTemp.transform.position.z);
			}
		}
		
	}
}
