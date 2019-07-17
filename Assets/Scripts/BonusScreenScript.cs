using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackButton(){
		SceneManager.LoadScene (0);
	}
	public void StoryButton(){
		SceneManager.LoadScene (11);
	}
	public void SongButton(){
		SceneManager.LoadScene (12);
	}
	public void CreditsButton(){
		SceneManager.LoadScene (13);
	}
}
