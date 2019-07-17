using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpScript : MonoBehaviour {

	public int fadeSpeed = 5;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, fadeSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text> ().color = Color.Lerp (gameObject.GetComponent<Text> ().color, Color.clear, fadeSpeed * Time.deltaTime); 
	}
}
