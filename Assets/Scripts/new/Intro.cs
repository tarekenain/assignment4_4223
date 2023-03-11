using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class Intro : MonoBehaviour
{
    void Start()
    {

        gameObject.GetComponent<readScores>().ShowTopScores();
    }

}
