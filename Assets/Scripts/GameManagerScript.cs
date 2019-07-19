using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using NotelineClass;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

	public TextAsset[] song1TextData;
	public AudioClip[] clips;
	public GameObject[] spawnPoints;
	public GameObject[] hitSpots;
	public float noteSpeed;
	public SongConverter song1;
	public List<Notes> song1notes;
	public GameObject[] note;
	public float bartime;
	public AudioSource audiothing;
	public bool songLoaded;
	public float barExecutedTime = 0.0f;
	public int min;
	public int max;
	public int notesSpawned;
	public Text resultsText;
	public bool songFinished;
	public int barCount = 0;
	float pitch;
	public float songPos;
	public int songChoice;
	public int totalHits;
	public bool paused;

	// Use this for initialization
	void Start () {
		songChoice = PlayerPrefs.GetInt ("songnumber");
		song1 = GetComponent<SongConverter> ();
		audiothing = GetComponent<AudioSource> ();
		audiothing.clip = clips [songChoice];
		song1.ConvertFromFile (song1TextData[songChoice]);
		bartime = (60.0f / song1.bpm) * 4.0f;
		noteSpeed = bartime/ 4.0f;
		audiothing.Play ();
		//StartCoroutine (PlaceBar (song1.song1data));
		songLoaded = true;
		paused = false;
	}
		
	
	// Update is called once per frame
	void Update () {
		if(paused == true){
			audiothing.Pause();
			
		}else if(!audiothing.isPlaying && paused == false){
			audiothing.Play();
		}

		if (songLoaded == true) {

			pitch = audiothing.pitch;
			songPos = audiothing.time;
			//if (((songPos/audiothing.clip.length)*100) >= ((min/song1.song1data.Count)*100)){
			if(paused == false){
				if (songPos - pitch >= (barExecutedTime - bartime)) {
					StartCoroutine (PlaceBar (song1.song1data, barCount++));
					barExecutedTime += bartime;
				}
			}	
			
			if (!audiothing.isPlaying && paused == false) {
				songLoaded = false;
				songFinished = true;
				int totalHits1 = (hitSpots[0].GetComponent<HitSpotScript> ().notesHit);
				int totalHits2 = (hitSpots[1].GetComponent<HitSpotScript> ().notesHit);
				int totalHits3 = (hitSpots[2].GetComponent<HitSpotScript> ().notesHit);
				totalHits = (totalHits1 + totalHits2 + totalHits3);
				PlayerPrefs.SetInt ("endScore", totalHits);
				PlayerPrefs.SetInt ("noteSpawn", notesSpawned);
				SceneManager.LoadScene (8);
			}

			}
		}
		



	IEnumerator PlaceBar(List<Notes> bar, int barCount)
	{
		min = (barCount * 4);
		max = (min + 4);

		for (int i = min; i <= max; i++){
			if (bar[i].left > 0)
			{
				Instantiate(note[bar[i].left-1],spawnPoints[0].transform.position , Quaternion.identity);
				notesSpawned++;
			}
			if (bar[i].middle > 0)
			{
				Instantiate(note[bar[i].middle-1],spawnPoints[1].transform.position , Quaternion.identity);
				notesSpawned++;
			}
			if (bar[i].right > 0)
			{
				Instantiate(note[bar[i].right-1],spawnPoints[2].transform.position , Quaternion.identity);
				notesSpawned++;
			}
		}
		yield return new WaitForSeconds ((bartime/4.0f) + Time.deltaTime);
		//yield return new WaitForSeconds((audiothing.clip.length/song1.song1data.Count) - timeOffset);
		//return null;
	}

	public void PauseButton(){
		paused = !paused;
		GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>().PlayPauseAnim();
		
	}



}
