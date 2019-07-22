using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int songSelected;
    public GameObject LeftButtonText;
    public GameObject MiddleButtonText;
    public GameObject RightButtonText;
    public GameObject[] AnimationArray;
    public GameObject ExtraAnim;
    public GameObject currentAnim; 
    public Sprite[] backgroundArray;
    public GameObject BackgroundPanel;
    public Sprite[] AnimationBackgroundArray;
    public GameObject currentAnimPanel;
    // Start is called before the first frame update
    void Start()
    {
        songSelected = PlayerPrefs.GetInt("songnumber");
        LeftButtonText.SetActive(false);
        MiddleButtonText.SetActive(false);
        RightButtonText.SetActive(false);
        if(SystemInfo.deviceType == DeviceType.Desktop){
            LoadButtonText();
        }
        BackgroundPanel.GetComponent<Image>().sprite = backgroundArray[songSelected-1];
        currentAnimPanel.GetComponent<Image>().sprite = AnimationBackgroundArray[songSelected-1];
        currentAnim = AnimationArray[songSelected-1];
        ExtraAnim.SetActive(false);
        foreach (var Anim in AnimationArray)
        {
            Anim.SetActive(false);
        }

        if(songSelected == 2){
            currentAnim.SetActive(true);
            ExtraAnim.SetActive(true);
        }else{
            currentAnim.SetActive(true);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadButtonText(){
        LeftButtonText.SetActive(true);
        MiddleButtonText.SetActive(true);
        RightButtonText.SetActive(true);
    }

    public void PlayPauseAnim(){
        if(songSelected == 2){
            currentAnim.GetComponent<Animator>().enabled =! currentAnim.GetComponent<Animator>().enabled;
            ExtraAnim.GetComponent<Animator>().enabled =! ExtraAnim.GetComponent<Animator>().enabled;
        }else{
            currentAnim.GetComponent<Animator>().enabled =! currentAnim.GetComponent<Animator>().enabled;
        }
        
    }
}
