using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public bool enemyTookDmg = false;
    public float timeToTakeDmgAgain = 0.25f;
    public float timer = 0f;
    
    public float damage = 2;
    public float enemyHealth = 4f;

    public Money moneyScript;

    
    public void Update()

    {
        
        if(enemyHealth <= 0f)
        {
            Destroy(gameObject);
            moneyScript.addMoney();
        }

        
        if(enemyTookDmg)
        {
            timer += Time.deltaTime;

            if(timer >= timeToTakeDmgAgain)
            {
                enemyTookDmg = false;
                timer = 0f;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(!enemyTookDmg)
        {
            if(collider.gameObject.CompareTag("AttackRange"))
            {
                enemyHealth -= damage;
                enemyTookDmg = true;
            }
        }
    }
}
