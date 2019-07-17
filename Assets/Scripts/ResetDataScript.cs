using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetDataScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Delete(){
		//deletes EVERYTHING.
		PlayerPrefs.DeleteAll();
		SceneManager.LoadScene (2);
	}
	public void BackButton(){
		SceneManager.LoadScene (2);
	}
}
