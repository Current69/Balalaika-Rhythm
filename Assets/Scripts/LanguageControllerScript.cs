using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageControllerScript : MonoBehaviour {

	public Text[] textFields;
	public bool isLangaugeEnglish;
	public string[] englishStrings;
	public string[] russianStrings;

	// Use this for initialization
	void Start () {
		CheckLangauge ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isLangaugeEnglish == true) {
			for (var i = 0; i < textFields.Length; i++) {
				textFields [i].text = englishStrings[i];
			}
		} else {
			for (var i = 0; i < textFields.Length; i++) {
				textFields [i].text = russianStrings [i];
			}	
		}
	}

	public void CheckLangauge(){
		
		if (PlayerPrefs.GetInt("english?") == 1){
			isLangaugeEnglish = true;
		} else{
			isLangaugeEnglish = false;
		}
		
	}
}
