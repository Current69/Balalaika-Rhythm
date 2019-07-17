using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeperScript : MonoBehaviour {

	public GameObject[] hitSpots;
	public Text scoreText;
	int totalHits;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int totalHits1 = (hitSpots[0].GetComponent<HitSpotScript> ().notesHit);
		int totalHits2 = (hitSpots[1].GetComponent<HitSpotScript> ().notesHit);
		int totalHits3 = (hitSpots[2].GetComponent<HitSpotScript> ().notesHit);
		totalHits = (totalHits1 + totalHits2 + totalHits3);

		scoreText.text = "Score: " + totalHits;
	}
}
