using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public SFX SFXScript;

    public ParticleSystem playerDamage;

    public int maxHealth = 10;
    public int currentHealth;
    

    public float playerAttackDamage = 2f;
    public int enemyAttackDamage = 2;
    [SerializeField] float timeBtwAttack = 1f;
    [SerializeField] float btwAttackTimer = 0f;
    public bool isInEnemyAttackRange = false;


    public SpriteRenderer healthBarSR;
    public Sprite zeroHPSprite;
    public Sprite oneHpSprite;
    public Sprite twoHPSprite;
    public Sprite threeHPSprite;
    public Sprite fourHPSprite;
    public Sprite fiveHPSprite;
    public Sprite sixHPSprite;
    public Sprite sevenHPSprite;
    public Sprite eightHPSprite;
    public Sprite nineHPSprite;
    public Sprite tenHPSprite;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update() 
    {
            if(currentHealth == 10)
            {
                healthBarSR.sprite = tenHPSprite;
            }

            else if(currentHealth == 9)
            {
                healthBarSR.sprite = nineHPSprite;
            }

            else if(currentHealth == 8)
            {
                healthBarSR.sprite = eightHPSprite;
            }

            else if(currentHealth == 7)
            {
                healthBarSR.sprite = sevenHPSprite;
            }

            else if(currentHealth == 6)
            {
                healthBarSR.sprite = sixHPSprite;
            }

            else if(currentHealth == 5)
            {
                healthBarSR.sprite = fiveHPSprite;
            }

            else if(currentHealth == 4)
            {
                healthBarSR.sprite = fourHPSprite;
            }

            else if(currentHealth == 3)
            {
                healthBarSR.sprite = threeHPSprite;
            }

            else if(currentHealth == 2)
            {
                healthBarSR.sprite = twoHPSprite;
            }

            else if(currentHealth == 1)
            {
                healthBarSR.sprite = oneHpSprite;
            }

            if(currentHealth <= 0)
            {
                healthBarSR.sprite = zeroHPSprite;
            }
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
                currentHealth -= enemyAttackDamage;
                btwAttackTimer = 0f;
            }
        }
    }

    public void OnTriggerExit2D()
    {
        btwAttackTimer = 0f;
    }
}
