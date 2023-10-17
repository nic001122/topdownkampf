using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public float damage = 2;
    public float enemyHealth = 4f;
    public void Update()
    {
        if(enemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("AttackRange"))
        {
            enemyHealth -= damage;
        }
    }
}
