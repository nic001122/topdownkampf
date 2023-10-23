using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class LightBattery : MonoBehaviour
{
    [SerializeField] Slider lightBatterySlider;
    public Light2D lantern;
    bool lightStatus = false;
    public float currentValueLight;
    public float maxValueLight = 20;
    public float lanternIntensity;
    


    void Start()
    {
        lantern.intensity = 0;
        currentValueLight = maxValueLight;
    }

    
    
    void Update()
    {
        lightBatterySlider.value = currentValueLight;
        switch (lantern.intensity)
        {
            case 1:
                currentValueLight -= Time.deltaTime; break;
            case 0:
                currentValueLight += Time.deltaTime; break;
        }
    }
}
