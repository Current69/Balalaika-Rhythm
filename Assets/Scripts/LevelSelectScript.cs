using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void level1Select(){
		PlayerPrefs.SetInt ("songnumber", 1);
		SceneManager.LoadScene (4);
	}
	public void level2Select(){
		PlayerPrefs.SetInt ("songnumber", 2);
		SceneManager.LoadScene (5);
	}
	public void level3Select(){
		PlayerPrefs.SetInt ("songnumber", 3);
		SceneManager.LoadScene (6);
	}
	public void BackButton(){
		SceneManager.LoadScene (0);
	}
}
