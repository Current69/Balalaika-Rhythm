using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testNoteScript : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		speed = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ().noteSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * speed);
	}
		
}
