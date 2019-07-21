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
    public GameObject currentAnim; 
    public Sprite[] backgroundArray;
    public GameObject BackgroundPanel;
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
        currentAnim = AnimationArray[songSelected-1];
        foreach (var Anim in AnimationArray)
        {
            Anim.SetActive(false);
        }

        currentAnim.SetActive(true);
        
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
        currentAnim.GetComponent<Animator>().enabled =! currentAnim.GetComponent<Animator>().enabled;
    }
}
