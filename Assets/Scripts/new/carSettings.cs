using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carSettings : MonoBehaviour
{

    public Slider spawnRateSlider;
    public Text spawnRateText;
    public static float spawnRateValue;
    public static float newSpawnRateValue;

    public void SetSpawnRate()
    {
        spawnRateValue = spawnRateSlider.value;
        newSpawnRateValue = spawnRateValue * 10;
        spawnRateText.text = newSpawnRateValue.ToString() + "%";
    }



    public Slider carSpeedSlider;
    public Text carSpeedText;
    public static float carSpeedValue;
    public static float newCarSpeedValue;

    public void SetCarSpeed()
    {
        carSpeedValue = carSpeedSlider.value;
        newCarSpeedValue = carSpeedValue * 10;
        carSpeedText.text = newCarSpeedValue.ToString() + "%";
    }

}
