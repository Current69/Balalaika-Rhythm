using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScreenScript : MonoBehaviour {

	public int totalHits;
	public string winString;
	public string loseString;
	public string russianWinString;
	public string russianLoseString;
	public Text resultsText;
	public Text resultsText2;
	public int notesSpawned;
	public int starCount;
	public Sprite[] stars;
	public GameObject starSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		notesSpawned = PlayerPrefs.GetInt ("noteSpawn");
		totalHits = PlayerPrefs.GetInt ("endScore");
		if ((notesSpawned * 0.2) < totalHits && totalHits < (notesSpawned * 0.3)) {
			
			if(PlayerPrefs.GetInt("english?") == 1){
				resultsText.text = winString;
			}else{
				resultsText.text = russianWinString;
			}
			
			resultsText2.text =  (totalHits + "/" + notesSpawned);
			starSpawn.GetComponent<Image> ().sprite = stars [1];

		} else if ((notesSpawned * 0.3) < totalHits && totalHits < (notesSpawned * 0.4)) {
			
			if(PlayerPrefs.GetInt("english?") == 1){
				resultsText.text = winString;
			}else{
				resultsText.text = russianWinString;
			}
			resultsText2.text =  (totalHits + "/" + notesSpawned);
			starSpawn.GetComponent<Image> ().sprite = stars [2];

		} else if ((notesSpawned * 0.4) < totalHits && totalHits < (notesSpawned * 0.5)) {
			
			if(PlayerPrefs.GetInt("english?") == 1){
				resultsText.text = winString;
			}else{
				resultsText.text = russianWinString;
			}
			resultsText2.text =  (totalHits + "/" + notesSpawned);
			starSpawn.GetComponent<Image> ().sprite = stars [3];

		} else if ((notesSpawned * 0.5) < totalHits && totalHits < (notesSpawned * 0.7)) {
			
			if(PlayerPrefs.GetInt("english?") == 1){
				resultsText.text = winString;
			}else{
				resultsText.text = russianWinString;
			}
			resultsText2.text =  (totalHits + "/" + notesSpawned);
			starSpawn.GetComponent<Image> ().sprite = stars [4];

		} else if ((notesSpawned * 0.7) < totalHits){
			
			if(PlayerPrefs.GetInt("english?") == 1){
				resultsText.text = winString;
			}else{
				resultsText.text = russianWinString;
			}
			resultsText2.text =  (totalHits + "/" + notesSpawned);
			starSpawn.GetComponent<Image> ().sprite = stars [5];

		} else {
			
			if(PlayerPrefs.GetInt("english?") == 1){
				resultsText.text = loseString;
			}else{
				resultsText.text = russianLoseString;
			}
			resultsText2.text =  (totalHits + "/" + notesSpawned);
			starSpawn.GetComponent<Image> ().sprite = stars [0];
		}

	}

	public void RestartLevel(){
		PlayerPrefs.DeleteKey ("noteSpawn");
		PlayerPrefs.DeleteKey ("endScore");
		SceneManager.LoadScene (7);
	}
	public void LevelSelect(){
		PlayerPrefs.DeleteKey ("noteSpawn");
		PlayerPrefs.DeleteKey ("endScore");
		PlayerPrefs.DeleteKey ("songnumber");
		SceneManager.LoadScene (1);
	}
	public void MenuSelect(){
		PlayerPrefs.DeleteKey ("noteSpawn");
		PlayerPrefs.DeleteKey ("endScore");
		PlayerPrefs.DeleteKey ("songnumber");
		SceneManager.LoadScene (0);
	}
}