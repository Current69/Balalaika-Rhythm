using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackButton(){
		SceneManager.LoadScene (3);
	}
	public void FrostButton(){
		SceneManager.LoadScene (14);
	}
}
