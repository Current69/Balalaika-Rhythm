using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SongConfirmScript : MonoBehaviour {

	public Text startButtonText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackButton(){
		SceneManager.LoadScene (1);
		
	}
	public void StartButton(){
		startButtonText.text = "Loading";
		SceneManager.LoadScene (7);
		
	}
}
