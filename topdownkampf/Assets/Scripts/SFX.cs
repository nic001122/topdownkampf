using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, dashS, enemyS, itemS, lightS, shopS, deathS, slashS;


    public void ButtonClick()
    {
        src.clip = sfx1;
        src.Play();
    }
    public void DashSound()
    {
        src.clip = dashS;
        src.Play();
    }
    public void EnemyDeathSound()
    {
        src.clip = enemyS;
        src.Play();
    }
    public void ItemPickUpSound()
    {
        src.clip = itemS;
        src.Play();
    }
    public void LightSwitchSound()
    {
        src.clip = lightS;
        src.Play();
    }
    public void ShopSound()
    {
        src.clip = shopS;
        src.Play();
    }
    public void PlayerDeathSound()
    {
        src.clip = deathS;
        src.Play();
    }
    public void SlashSound()
    {
        src.clip = slashS;
        src.Play();
    }
}
