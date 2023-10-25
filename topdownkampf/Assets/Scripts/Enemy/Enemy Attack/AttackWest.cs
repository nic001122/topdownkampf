using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackWest : MonoBehaviour
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
        if(newEnemy.playerLantern.intensity > 0)
        {
            return;
        }

        if(timerBeforeFirstAttack >= 1f)
        {
            timerBeforeFirstAttack = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(newEnemy.playerLantern.intensity > 0)
        {
            return;
        }

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

    void OnTriggerStay2D()
    {
        if(newEnemy.playerLantern.intensity > 0)
        {
            return;
        }

        if
        (
            enemyDetermineChildren.isAttackingNorthWest == false &&
            enemyDetermineChildren.isAttackingNorthEast == false &&
            
            enemyDetermineChildren.isAttackingSouthWest == false &&
            enemyDetermineChildren.isAttackingSouthEast == false &&

            enemyDetermineChildren.isAttackingNorth == false &&
            enemyDetermineChildren.isAttackingSouth == false &&

            enemyDetermineChildren.isAttackingEast == false &&

            timerBeforeFirstAttack >= 0f
        )
        
        {
            if(playerIsInRange)
            {
                timerBeforeFirstAttack += Time.deltaTime;
                if(timerBeforeFirstAttack >= 1)
                {
                    enemyDetermineChildren.attackRangeWest.SetActive(true);
                    enemyDetermineChildren.isAttackingWest = true;

                    if(btwAttackTimer >= timeBtwAttack)
                    {
                        enemyDetermineChildren.attackRangeWest.SetActive(false);
                    }
                }
            }

            if(enemyDetermineChildren.isAttackingWest)
            {
                btwAttackTimer += Time.deltaTime;
            }

            if(btwAttackTimer >= timeBtwAttack)
            {
                enemyDetermineChildren.attackRangeWest.SetActive(false);
                enemyDetermineChildren.isAttackingWest = false;

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
}
