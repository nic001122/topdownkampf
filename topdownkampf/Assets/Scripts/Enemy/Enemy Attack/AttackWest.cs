using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AttackWest : MonoBehaviour
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

            enemyDetermineChildren.isAttackingNorth == false &&
            enemyDetermineChildren.isAttackingSouth == false &&

            enemyDetermineChildren.isAttackingEast == false &&

            btwAttackTimer >= maxBtwAttackTimer &&

            playerIsInRange
        )

        {

            if(firstAttackHappened)
            {
                enemyDetermineChildren.attackRangeWest.SetActive(true);
                enemyDetermineChildren.isAttackingWest = true;

                endOfAttackTimer += Time.deltaTime;

                if(endOfAttackTimer >= endOfAttack)
                {
                    endOfAttackTimer = timeReset;
                    btwAttackTimer = timeReset;
                    enemyDetermineChildren.attackRangeWest.SetActive(false);
                    enemyDetermineChildren.isAttackingWest = false;
                    boolBtwAttack = true;
                }
            }

            else if(!firstAttackHappened)
            {
                timeBeforeFirstAttack += Time.deltaTime;

                if(timeBeforeFirstAttack >= maxBeforeFirstAttack)
                {
                    enemyDetermineChildren.attackRangeWest.SetActive(true);
                    enemyDetermineChildren.isAttackingWest = true;

                    firstEndOfAttackTimer += Time.deltaTime;

                    if(firstEndOfAttackTimer >= firstEndOfAttack)
                    {
                        timeBeforeFirstAttack = timeReset;
                        btwAttackTimer = timeReset;
                        enemyDetermineChildren.attackRangeWest.SetActive(false);
                        enemyDetermineChildren.isAttackingWest = false;
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
