using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class StoryControllerScript : MonoBehaviour {
	
	public Sprite[] Images;
	public Image placeHolder;
	public int page;
	public string[] storyText;
	public Text placeholderText;
	public bool split;
	public GameObject TitleText;
	public string[] RussianText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		placeHolder.sprite = Images [page];

		if(PlayerPrefs.GetInt("english?") == 1){
			placeholderText.text = storyText[page];
		}else{
			placeholderText.text = RussianText[page];
		}
		
		if(page == 0){
			TitleText.SetActive(true);
		}else{
			TitleText.SetActive(false);
		}
	}
	public void BackButton(){
		SceneManager.LoadScene (11);
	}
	public void LeftArrow(){
		if (page > 0) {
			page--;
		}

	}
	public void RightArrow(){
		if (page < 18) {
			page++;
		}

	}
	public void UpdatePage(){
		//change the text based on the page int
	}
}
