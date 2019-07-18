using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartButton(){
		SceneManager.LoadScene (1);
	}
	public void OptionButton(){
		SceneManager.LoadScene(2);
	}
	public void BonusButton(){
		SceneManager.LoadScene (3);
	}
	public void QuitButton(){
		Application.Quit();
	}
}
