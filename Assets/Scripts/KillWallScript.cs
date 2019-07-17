using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillWallScript : MonoBehaviour {

	//basic kill wall, destroy what enters it, note blocks pretty much

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Missed!");
		Destroy (other.gameObject);

	}
		
}
