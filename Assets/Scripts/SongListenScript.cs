using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongListenScript : MonoBehaviour {

	public AudioClip[] clips;
	public AudioClip loadedClip;
	public AudioSource cameraAudio;


	// Use this for initialization
	void Start () {
		cameraAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (cameraAudio.isPlaying == false) {
			loadedClip = clips [7];
			PlayMusic ();
		}
		
	}
	public void BackButton(){
		SceneManager.LoadScene (3);
	}
	public void MenuSongButton(){
		loadedClip = clips [0];
		PlayMusic ();
	}

	public void BarynyaSongButton(){
		loadedClip = clips [1];
		PlayMusic ();
	}

	public void SmugliankaSongButton(){
		loadedClip = clips [2];
		PlayMusic ();
	}

	public void MedleySongButton(){
		loadedClip = clips [3];
		PlayMusic ();
	}

	public void CossacksSongButton(){
		loadedClip = clips [4];
		PlayMusic ();
	}

	public void YablochkoSongButton(){
		loadedClip = clips [5];
		PlayMusic ();
	}

	public void TroikaSongButton(){
		loadedClip = clips [6];
		PlayMusic ();
	}

	void PlayMusic(){
		cameraAudio.clip = loadedClip;
		cameraAudio.Play ();
	}
}
