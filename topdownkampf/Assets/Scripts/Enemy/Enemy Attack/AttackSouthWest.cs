using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackSouthWest : MonoBehaviour
{
    public EnemyDetermineChildren enemyDetermineChildren;

    [SerializeField] bool playerIsInRange = false;

    [SerializeField] float timeBtwAttack = 0.25f;
    [SerializeField] float btwAttackTimer = 0f;
    [SerializeField] float timerBeforeFirstAttack = 0f;


    public NewEnemy newEnemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if
        (
            enemyDetermineChildren.isAttackingNorthWest == false &&
            enemyDetermineChildren.isAttackingNorthEast == false &&
            
            enemyDetermineChildren.isAttackingSouthEast == false &&

            enemyDetermineChildren.isAttackingNorth == false &&
            enemyDetermineChildren.isAttackingSouth == false &&

            enemyDetermineChildren.isAttackingWest == false &&
            enemyDetermineChildren.isAttackingEast == false &&

            timerBeforeFirstAttack >= 0f
        )

        {
            if(playerIsInRange)
            {
                timerBeforeFirstAttack += Time.deltaTime;
                if(timerBeforeFirstAttack >= 1)
                {
                    enemyDetermineChildren.attackRangeSouthWest.SetActive(true);
                    enemyDetermineChildren.isAttackingSouthWest = true;

                    if(btwAttackTimer >= timeBtwAttack)
                    {
                        enemyDetermineChildren.attackRangeSouthWest.SetActive(false);
                    }
                }
            }

            if(enemyDetermineChildren.isAttackingSouthWest)
            {
                btwAttackTimer += Time.deltaTime;
            }

            if(btwAttackTimer >= timeBtwAttack)
            {
                enemyDetermineChildren.attackRangeSouthWest.SetActive(false);
                enemyDetermineChildren.isAttackingSouthWest = false;

                btwAttackTimer = 0f;
            }

            if(btwAttackTimer > 0)
            {
                btwAttackTimer = 0f;
            }
        }

        if(timerBeforeFirstAttack >= 1f)
        {
            timerBeforeFirstAttack = 0f;
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

        btwAttackTimer = 0f;

        timerBeforeFirstAttack = 1f;
    }
}
