using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class Exit : MonoBehaviour
{
    
    public Text showHighScore;
    

    public void Start()
    {
        gameObject.GetComponent<writeScores>().AddNewScore();
        gameObject.GetComponent<readScores>().ShowTopScores();

        int newhighscore;
        newhighscore = Score.highScorePref;
        showHighScore.text = newhighscore.ToString();

        
    }

}
