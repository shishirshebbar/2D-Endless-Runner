using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Event : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
        UnityEditor.EditorApplication.isPlaying=false;
    }
}
