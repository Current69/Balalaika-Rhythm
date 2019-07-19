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
    // Start is called before the first frame update
    void Start()
    {
        LeftButtonText.SetActive(false);
        MiddleButtonText.SetActive(false);
        RightButtonText.SetActive(false);
        if(SystemInfo.deviceType == DeviceType.Desktop){
            LoadButtonText();
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
        Song1Anim.enabled =! Song1Anim.enabled; 
    }
}
