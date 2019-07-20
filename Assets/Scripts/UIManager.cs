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
    public Animator Song1Anim;
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
        Song1Anim.enabled =! Song1Anim.enabled; 
    }
}
