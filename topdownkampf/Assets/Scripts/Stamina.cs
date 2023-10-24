using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
 
public class Stamina : MonoBehaviour
{
    [SerializeField] Slider staminaSlider;
 
    public float maxStamina = 10;
    public float currentStamina;
    public float tempStamina;
 
    public bool staminaIsBeingUsed = false;
    public bool staminaIsRefilling = false;
    public float startRefillTimer = 0f;
    public float endRefillTimer = 1f;
 
    // Start is called before the first frame update
    void Start()
    {
        currentStamina = maxStamina;
        tempStamina = maxStamina;
    }
 
    // Update is called once per frame
    void Update()
    {
        staminaSlider.value = tempStamina;
 
        if(tempStamina != currentStamina)
        {
            if(tempStamina < currentStamina)
            {
                tempStamina += 2f * Time.deltaTime;
            }
 
            if(tempStamina > currentStamina)
            {
                tempStamina -= 2f * Time.deltaTime;
            }
        }
 
        if(staminaIsRefilling)
        {
            currentStamina = maxStamina;
        }
 
        if(tempStamina <= maxStamina && tempStamina >= 9.9f && currentStamina == maxStamina)
        {
            staminaIsRefilling = false;
        }
 
        if(!staminaIsBeingUsed && currentStamina < maxStamina && tempStamina < maxStamina && currentStamina >= tempStamina)
        {
            startRefillTimer += Time.deltaTime;
 
            if(startRefillTimer >= endRefillTimer)
            {
                staminaIsRefilling = true;
                startRefillTimer = 0f;
            }
        }

        if(startRefillTimer >= endRefillTimer)
        {
            staminaIsRefilling = true;
            startRefillTimer = 0f;
        }
 
        if(staminaIsBeingUsed && currentStamina < maxStamina && tempStamina < maxStamina && currentStamina >= tempStamina)
        {
            startRefillTimer = 0f;
        }
    }
}