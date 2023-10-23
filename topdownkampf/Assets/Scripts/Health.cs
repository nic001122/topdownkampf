using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Slider healthBar;

    public float maxHealth = 10;
    public float currentHealth;
    

    [SerializeField] float timeBtwAttack = 1f;
    [SerializeField] float btwAttackTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;


        if (Input.GetKeyDown(KeyCode.E))
        {
            currentHealth = currentHealth - 2;
        }
        if (currentHealth <= 0)
        {
            
            Destroy(gameObject, 0.1f);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy Attack Range"))
        {
            currentHealth -= 2.5f;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy Attack Range"))
        {
            btwAttackTimer += Time.deltaTime;
            if(btwAttackTimer >= timeBtwAttack)
            {
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
