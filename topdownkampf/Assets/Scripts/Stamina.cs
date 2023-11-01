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
    public SpriteRenderer staminaSR;
    public Sprite zeroStaminaSprite;
    public Sprite oneStaminaSprite;
    public Sprite twoStaminaSprite;
    public Sprite threeStaminaSprite;
    public Sprite fourStaminaSprite;
    public Sprite fiveStaminaSprite;
    public Sprite sixStaminaSprite;
    public Sprite sevenStaminaSprite;
    public Sprite eighStaminaSprite;
    public Sprite nineStaminaSprite;
    public Sprite tenStaminaSprite;
 
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
        staminaSpriteCheck();
 
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

    public void staminaSpriteCheck()
    {
        switch(currentStamina)
        {
            case 0:
            staminaSR.sprite = zeroStaminaSprite;
            break;
            
            case 1:
            staminaSR.sprite = oneStaminaSprite;
            break;

            case 2:
            staminaSR.sprite = twoStaminaSprite;
            break;

            case 3:
            staminaSR.sprite = threeStaminaSprite;
            break;

            case 4:
            staminaSR.sprite = fourStaminaSprite;
            break;

            case 5:
            staminaSR.sprite = fiveStaminaSprite;
            break;

            case 6:
            staminaSR.sprite = sixStaminaSprite;
            break;

            case 7:
            staminaSR.sprite = sevenStaminaSprite;
            break;

            case 8:
            staminaSR.sprite = eighStaminaSprite;
            break;

            case 9:
            staminaSR.sprite = nineStaminaSprite;
            break;

            case 10:
            staminaSR.sprite = tenStaminaSprite;
            break;
        }
    }
}