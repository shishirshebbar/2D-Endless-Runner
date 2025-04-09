using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Pause : MonoBehaviour
{
    [SerializeField] public GameObject pauseMenu;
    
    public void PauseMenu(){
        pauseMenu.SetActive(true);
        Time.timeScale=0f;
    }

    
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
    }
    public void Home(){
        
        Time.timeScale=1f;
        SceneManager.LoadScene("HomePage");
    }
    public void Restart(){        
        Time.timeScale=1f;
        SceneManager.LoadScene("GamePlay");
    }
}
