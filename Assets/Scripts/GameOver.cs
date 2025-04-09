using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("SubPlayer")==null)
        {
            GameOverPanel.SetActive(true);
        }
        
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Home(){
        SceneManager.LoadScene("HomePage");
    }
}
