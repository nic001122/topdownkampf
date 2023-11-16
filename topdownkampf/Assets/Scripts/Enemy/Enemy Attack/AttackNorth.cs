using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AttackNorth : MonoBehaviour
{

    public EnemyDetermineChildren enemyDetermineChildren;

    [SerializeField] bool playerIsInRange = false;

    [SerializeField] bool firstAttackHappened = false;
    [SerializeField] bool boolBtwAttack = false;
    float timeReset = 0f;

    [SerializeField] float btwAttackTimer = 0f;
    [SerializeField] float maxBtwAttackTimer = 1f;

    [SerializeField] float timeBeforeFirstAttack = 0f;
    [SerializeField] float maxBeforeFirstAttack = 1f;

    [SerializeField] float firstEndOfAttackTimer = 0f;
    [SerializeField] float firstEndOfAttack = 0.25f;

    [SerializeField] float endOfAttackTimer = 0f;
    [SerializeField] float endOfAttack = 0.25f;
    

    // Start is called before the first frame update
    void Start()
    {
        btwAttackTimer = maxBtwAttackTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if
        (
            enemyDetermineChildren.isAttackingNorthWest == false &&
            enemyDetermineChildren.isAttackingNorthEast == false &&
            
            enemyDetermineChildren.isAttackingSouthWest == false &&
            enemyDetermineChildren.isAttackingSouthEast == false &&

            enemyDetermineChildren.isAttackingSouth == false &&

            enemyDetermineChildren.isAttackingEast == false &&
            enemyDetermineChildren.isAttackingWest == false &&

            btwAttackTimer >= maxBtwAttackTimer &&

            playerIsInRange
        )

        {

            if(firstAttackHappened)
            {
                enemyDetermineChildren.attackRangeNorth.SetActive(true);
                enemyDetermineChildren.isAttackingNorth = true;

                endOfAttackTimer += Time.deltaTime;

                if(endOfAttackTimer >= endOfAttack)
                {
                    endOfAttackTimer = timeReset;
                    btwAttackTimer = timeReset;
                    enemyDetermineChildren.attackRangeNorth.SetActive(false);
                    enemyDetermineChildren.isAttackingNorth = false;
                    boolBtwAttack = true;
                }
            }

            else if(!firstAttackHappened)
            {
                timeBeforeFirstAttack += Time.deltaTime;

                if(timeBeforeFirstAttack >= maxBeforeFirstAttack)
                {
                    enemyDetermineChildren.attackRangeNorth.SetActive(true);
                    enemyDetermineChildren.isAttackingNorth = true;

                    firstEndOfAttackTimer += Time.deltaTime;

                    if(firstEndOfAttackTimer >= firstEndOfAttack)
                    {
                        timeBeforeFirstAttack = timeReset;
                        btwAttackTimer = timeReset;
                        enemyDetermineChildren.attackRangeNorth.SetActive(false);
                        enemyDetermineChildren.isAttackingNorth = false;
                        firstAttackHappened = true;
                        boolBtwAttack = true;
                    }
                }
            }
        }

        if(boolBtwAttack)
        {
            btwAttackTimer += Time.deltaTime;

            if(btwAttackTimer >= maxBtwAttackTimer)
            {
                boolBtwAttack = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsInRange = true;
        }
    }

    void OnTriggerExit2D()
    {
        playerIsInRange = false;

        firstAttackHappened = false;

        btwAttackTimer = timeReset;
        timeBeforeFirstAttack = timeReset;
    }
}
