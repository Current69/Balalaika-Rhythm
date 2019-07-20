using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    
    public void RestartButton(){
        SceneManager.LoadScene(7);
    }
    public void QuitButton(){
        SceneManager.LoadScene(0);
    }
}
