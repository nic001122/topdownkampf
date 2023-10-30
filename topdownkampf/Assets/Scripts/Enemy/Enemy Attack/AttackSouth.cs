using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSouth : MonoBehaviour
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
            
            enemyDetermineChildren.isAttackingSouthWest == false &&
            enemyDetermineChildren.isAttackingSouthEast == false &&

            enemyDetermineChildren.isAttackingNorth == false &&

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
                    enemyDetermineChildren.attackRangeSouth.SetActive(true);
                    enemyDetermineChildren.isAttackingSouth = true;

                    if(btwAttackTimer >= timeBtwAttack)
                    {
                        enemyDetermineChildren.attackRangeSouth.SetActive(false);
                    }
                }
            }

            if(enemyDetermineChildren.isAttackingSouth)
            {
                btwAttackTimer += Time.deltaTime;
            }

            if(btwAttackTimer >= timeBtwAttack)
            {
                enemyDetermineChildren.attackRangeSouth.SetActive(false);
                enemyDetermineChildren.isAttackingSouth = false;

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
