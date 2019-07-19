using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testNoteScript : MonoBehaviour {
	public float speed;
	public bool paused;

	// Use this for initialization
	void Start () {
		speed = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ().noteSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		paused = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>().paused;
		if (paused == false){
			transform.Translate (Vector2.down * speed);
		}
		
	}
		
}
