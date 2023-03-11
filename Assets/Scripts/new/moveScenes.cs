using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScenes : MonoBehaviour
{
    public void ToIntro()
    {
        PlayerPrefs.SetInt("HighScorePref", 0);
        PlayerPrefs.Save();
        Debug.Log("Score has been reset to " + PlayerPrefs.GetInt("HighScorePref"));
        Score.resetScore = 0;
        SceneManager.LoadScene("Intro");
    }

    public void ToMain()
    {
        PlayerPrefs.SetInt("HighScorePref", 0);
        
        PlayerPrefs.Save();
        Debug.Log("Score has been reset to " + PlayerPrefs.GetInt("HighScorePref"));
        Score.resetScore = 0;
        SceneManager.LoadScene("Main");
    }

    public void ToExit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Exit");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


}
