using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsScript : MonoBehaviour {

	public GameObject languageControl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackButton(){
		SceneManager.LoadScene (0);
	}
	public void LanguageButton(){
		if (PlayerPrefs.GetInt ("english?") == 1) {
			PlayerPrefs.SetInt ("english?", 0);
			PlayerPrefs.Save();
		} else {
			PlayerPrefs.SetInt ("english?", 1);
			PlayerPrefs.Save();
		}
		languageControl.GetComponent<LanguageControllerScript> ().CheckLangauge ();
	}
	public void VolumeButton(){
		SceneManager.LoadScene (10);
	}
	public void ResetButton(){
		SceneManager.LoadScene (9);
	}
}
