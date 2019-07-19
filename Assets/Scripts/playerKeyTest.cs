using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerKeyTest : MonoBehaviour {

	public AudioClip[] clips;
	public GameObject[] hitSpots;
	public RaycastHit2D hit;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
			Vector2[] touches = new Vector2[5];
			for (int i = 0; i < Input.touchCount; i++) {
				touches [i] = Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position);
				if (Input.GetTouch (i).phase == TouchPhase.Began) {
					hit = Physics2D.Raycast (touches [i], Vector2.zero);
				}
				if (hit.collider.gameObject == hitSpots[0]) {
					hitSpots [0].GetComponent<HitSpotScript> ().click = true;
				}
				if (hit.collider.gameObject == hitSpots [1]) {
					hitSpots [1].GetComponent<HitSpotScript> ().click = true;
				}
				if (hit.collider.gameObject == hitSpots[2]){
					hitSpots [2].GetComponent<HitSpotScript> ().click = true;
				}
				if (Input.GetTouch (i).phase == TouchPhase.Ended) {
					hitSpots [0].GetComponent<HitSpotScript> ().click = false;
					hitSpots [1].GetComponent<HitSpotScript> ().click = false;
					hitSpots [2].GetComponent<HitSpotScript> ().click = false;
				}
			}
		}
		if (Application.platform == RuntimePlatform.WindowsPlayer) {
			if (Input.GetKey (KeyCode.A)) {
				hitSpots [0].GetComponent<HitSpotScript> ().click = true;
			} else {
				hitSpots [0].GetComponent<HitSpotScript> ().click = false;
			}
			if (Input.GetKey (KeyCode.W)) {
				hitSpots [1].GetComponent<HitSpotScript> ().click = true;
			} else {
				hitSpots [1].GetComponent<HitSpotScript> ().click = false;
			}
			if (Input.GetKey (KeyCode.D)) {
				hitSpots [2].GetComponent<HitSpotScript> ().click = true;
			} else {
				hitSpots [2].GetComponent<HitSpotScript> ().click = false;
			}
		}
		if (Application.platform == RuntimePlatform.WindowsEditor) {
			if (Input.GetKey (KeyCode.A)) {
				hitSpots [0].GetComponent<HitSpotScript> ().click = true;
			} else {
				hitSpots [0].GetComponent<HitSpotScript> ().click = false;
			}
			if (Input.GetKey (KeyCode.W)) {
				hitSpots [1].GetComponent<HitSpotScript> ().click = true;
			} else {
				hitSpots [1].GetComponent<HitSpotScript> ().click = false;
			}
			if (Input.GetKey (KeyCode.D)) {
				hitSpots [2].GetComponent<HitSpotScript> ().click = true;
			} else {
				hitSpots [2].GetComponent<HitSpotScript> ().click = false;
			}
		}
	}
		
}
