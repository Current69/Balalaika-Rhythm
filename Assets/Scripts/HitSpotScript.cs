using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitSpotScript : MonoBehaviour {

	public bool click;
	public int notesHit;
	public GameObject scoreUp;
	public Transform canvasObject;

	// Use this for initialization
	void Start () {
		canvasObject = gameObject.transform.GetChild(0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D other){
		GetComponent<SpriteRenderer> ().color = Color.blue;

		if (click == true){
			Debug.Log ("You did it!");
			if (other.gameObject.tag == "Note") {
				notesHit++;
				Destroy (other.gameObject);
				GetComponent<SpriteRenderer> ().color = Color.white;
				GameObject temp = Instantiate (scoreUp) as GameObject;
				temp.GetComponent<Text> ().text = "+1";
				temp.transform.SetParent (canvasObject, false);
			}
			if (other.gameObject.tag == "Bomb") {
				notesHit -= 5;
				Destroy (other.gameObject);
				GetComponent<SpriteRenderer> ().color = Color.white;
				GameObject temp = Instantiate (scoreUp) as GameObject;
				temp.GetComponent<Text> ().text = "-5";
				temp.transform.SetParent (canvasObject, false);
			}
			if (other.gameObject.tag == "Double") {
				notesHit += 5;
				Destroy (other.gameObject);
				GetComponent<SpriteRenderer> ().color = Color.white;
				GameObject temp = Instantiate (scoreUp) as GameObject;
				temp.GetComponent<Text> ().text = "+5";
				temp.transform.SetParent (canvasObject, false);
			}
		}
	}
	void OnTriggerExit2D(Collider2D other){
		GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
