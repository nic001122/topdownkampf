using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public ParticleSystem playerDamage;

    [SerializeField] Slider healthBar;

    public float maxHealth = 10;
    public float currentHealth;
    

    public float playerAttackDamage = 2f;
    [SerializeField] float timeBtwAttack = 1f;
    [SerializeField] float btwAttackTimer = 0f;
    public bool isInEnemyAttackRange = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy Attack Range"))
        {
            isInEnemyAttackRange = true;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy Attack Range") && isInEnemyAttackRange)
        {
            btwAttackTimer += Time.deltaTime;
            if(btwAttackTimer >= timeBtwAttack)
            {
                playerDamage.Play();
                currentHealth -= 2.5f;
                btwAttackTimer = 0f;
            }
        }
    }

    public void OnTriggerExit2D()
    {
        btwAttackTimer = 0f;
    }
}
